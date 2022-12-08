from flask import Blueprint, render_template, request
from flask_login import login_required, current_user
import requests

views = Blueprint('views', __name__)

@views.route('/')
def home():
    return render_template("index.html")

@views.route('/tienda')
def tienda():
    return render_template("tienda.html")

@views.route('/carrito')

@login_required
def carrito():
    return render_template("carrito.html")

@views.route('/finalizarcompra')
@login_required
def fc():
    return render_template("finalizar_compra.html")

@views.route('/comprafinal')
@login_required
def compra_final():
    return render_template("compra_lista.html")

@views.route('/menustaff')
@login_required
def menustaff():
    return render_template("menu_staff.html")

@views.route('/inventario')
@login_required
def inventario():
    data = requests.get('http://localhost:5057/Insumos')
    insumos = data.json() #Lista de insumos (diccionarios)
    #tienda = current_user.get_tienda()
    #insumos_lista = []
    #for insumo in insumos:
    #    if insumo['iD_Tienda'] == str(tienda):
    #        insumos_lista.append(insumo)
    
    return render_template("inventario.html", user=current_user, inventario=insumos)

@views.route('/productosstaff')
@login_required
def productosstaff():
    return render_template("productos_staff.html")

@views.route('/estadisticas')
@login_required
def estadisticas():
    return render_template("estadisticas.html")

@views.route('/pedidos')
@login_required
def pedidos():
    return render_template("pedidos.html")

@views.route('/agregarinsumos')
@login_required
def agregarinsumos():
    return render_template("agregar_insumo.html")

@views.route('/editarproducto')
@login_required
def editarproducto():
    return render_template("editar_producto.html")