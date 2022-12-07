from flask import Blueprint, render_template, request

views = Blueprint('views', __name__)

@views.route('/')
def home():
    return render_template("index.html")

@views.route('/tienda')
def tienda():
    return render_template("tienda.html")

@views.route('/carrito')
def carrito():
    return render_template("carrito.html")

@views.route('/finalizarcompra')
def fc():
    return render_template("finalizar_compra.html")

@views.route('/comprafinal')
def compra_final():
    return render_template("compra_lista.html")

@views.route('/registrocliente')
def registrocliente():
    return render_template("registrarcliente.html")


@views.route('/sesion')
def sesion():
    return render_template("sesion.html")

@views.route('/menustaff')
def menustaff():
    return render_template("menu_staff.html")

@views.route('/inventario')
def inventario():
    return render_template("inventario.html")

@views.route('/productos')
def productos():
    return render_template("productos.html")

@views.route('/estadisticas')
def estadisticas():
    return render_template("estadisticas.html")

@views.route('/pedidos')
def pedidos():
    return render_template("pedidos.html")