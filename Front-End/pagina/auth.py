from flask import Blueprint, render_template, request, flash, redirect, url_for
import requests
from werkzeug.security import generate_password_hash, check_password_hash
from flask_login import login_user, login_required, logout_user, current_user
from .clases import Client, Staff

auth = Blueprint('auth', __name__)

@auth.route('/login', methods=['GET','POST'])
def login():
        if request.method == 'POST':
            nombre = request.form.get('Nombre')
            pwd = request.form.get('password')
            #Buscar entre los clientes
            
            Clients = requests.get('http://localhost:5058/Clientes')
            clientsjson = Clients.json()
            isclient = False
            for client in clientsjson:
                if client['nombre'] == nombre:
                    cclient = Client(client['iD_Cliente'], client['nombre'], client['rut'], client['contrasena'])
                    isclient = True
            if isclient:
                if check_password_hash(cclient.pwd, pwd):
                    flash('Inició sesión correctamente!', category='success')
                    login_user(cclient, remember=True)
                    return redirect(url_for('views.home'))
                else:
                    flash('Contraseña equivocada, intente nuevamente', category='error')
                    return redirect(url_for('auth.login'))
            #Buscar entre el Staff
            rstaff = requests.get('http://localhost:5058/STAFF')
            staffjson = rstaff.json()
            isstaff = False
            for staff in staffjson:
                if staff['nombre'] == nombre:
                    cstaff = Staff(staff['iD_STAFF'], staff['nombre'], staff['iD_Tienda'], staff['contrasena'])
                    isstaff = True
            if isstaff:
                if check_password_hash(cstaff.pwd, pwd):
                    flash('Inició sesión correctamente!', category='success')
                    login_user(cstaff, remember=True)
                    return redirect(url_for('views.menustaff'))
                else:
                    flash('Contraseña equivocada, intente nuevamente', category='error')
                    return redirect(url_for('auth.login'))
            else:
                flash('Usuario no existe', category='error')
                return redirect(url_for('auth.login'))

        return render_template("sesion.html")#, user=current_user)

@auth.route('/logout', methods=['GET','POST'])
@login_required
def logout():
    logout_user()
    return redirect(url_for('views.home'))

@auth.route('/sign-up-client', methods=['GET','POST'])
def registrar_cliente():
    if request.method == 'POST': #Obtenemos datos del formulario
        nombre = request.form.get('Nombre')
        rut = request.form.get('RUT')
        password1 = request.form.get('password1')
        password2 = request.form.get('password2')

        if len(nombre) < 2: #Comprobaciones de seguridad
            flash('Nombre debe ser más largo que 1 caracter', category='error')
            return redirect(url_for('auth.registrar_cliente'))
        elif password1 != password2:
            flash('Las contraseñas no coinciden', category='error')
            return redirect(url_for('auth.registrar_cliente'))
        else: #Todo en orden, creamos la cuenta
            payload = {'nombre' : nombre, 'rut' : rut , 'contrasena' : generate_password_hash(password1, method='sha256')} #Agregamos algo de seguridad a las contrasenas
            r = requests.post('http://localhost:5058/Clientes', json=payload)
            id = r.json()['iD_Cliente']
            new_client = Client(id, nombre, rut, payload['contrasena'])
            login_user(new_client, remember=True)
            flash('Cuenta creada!', category='success')
            return redirect(url_for('views.home'))
    else:
        return render_template("registrar cliente.html")

@auth.route('/sign-up-staff', methods=['GET','POST'])
def registrar_staff():
    if request.method == 'POST':
        nombre = request.form.get('Nombre')
        iD_Tienda = int(request.form.get('tienda'))
        password1 = request.form.get('password1')
        password2 = request.form.get('password2')
        #Verificar que la tienda existe
        tiendas = requests.get('http://localhost:5058/Tiendas')
        tiendasjson = tiendas.json()
        tienda_exists = False
        for tienda in tiendasjson:
            if tienda['iD_Tienda'] == iD_Tienda:
                tienda_exists = True
        if not tienda_exists:
            flash('La tienda ingresada no existe en el sistema', category='error')
            return redirect(url_for('auth.registrar_staff'))
        elif len(nombre) < 2:
            flash('Nombre debe ser más largo que 1 caracter', category='error')
            return redirect(url_for('auth.registrar_staff'))
        elif password1 != password2:
            flash('Las contraseñas no coinciden', category='error')
            return redirect(url_for('auth.registrar_staff'))
        else:
            payload = {'nombre' : nombre, 'contrasena' : generate_password_hash(password1, method='sha256'), 'iD_Tienda' : iD_Tienda} 
            r = requests.post('http://localhost:5058/STAFF', json=payload)
            id = r.json()['iD_STAFF']
            new_staff = Staff(id, nombre, iD_Tienda, payload['contrasena'])
            login_user(new_staff, remember=True)
            flash('Cuenta creada!', category='success')
            return redirect(url_for('views.menustaff'))
    else:
        return render_template("registrar staff.html")

@auth.route('/sign-up-tienda', methods=['GET','POST'])
def registrar_tienda():
    if request.method == 'POST':
        nombre = request.form.get('Nombre')
        insta = request.form.get('instagram')

        if len(nombre) < 2:
            flash('Nombre debe ser más largo que 1 caracter', category='error')
            return redirect(url_for('auth.registrar_tienda'))
        else:
            new_tienda = {'nombre' : nombre, 'instagram' : insta}
            r = requests.post('http://localhost:5058/Tiendas', json=new_tienda)
            flash('Tienda registrada! El ID de su tienda es: '+str(r.json()['iD_Tienda']), category='success') #Mostramos el iD de la tienda que se requiere para crear una cuenta de Staff
            return redirect(url_for('views.home'))
    else:
        return render_template("registrar tienda.html")