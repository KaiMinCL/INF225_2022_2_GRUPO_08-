from flask import Blueprint, render_template, request

auth = Blueprint('auth', __name__)

@auth.route('/login', methods=['GET','POST'])
def login():
    return render_template("sesion.html")

@auth.route('/sign-up-client', methods=['GET','POST'])
def registrar_cliente():
    return render_template("registrar cliente.html")

@auth.route('/sign-up-staff', methods=['GET','POST'])
def registrar_staff():
    return render_template("registrar staff.html")

@auth.route('/sign-up-tienda', methods=['GET','POST'])
def registrar_tienda():
    return render_template("registrar tienda.html")