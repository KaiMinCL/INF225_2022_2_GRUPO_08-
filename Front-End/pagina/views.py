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