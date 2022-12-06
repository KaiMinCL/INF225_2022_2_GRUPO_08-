from flask import Blueprint, render_template, request

auth = Blueprint('auth', __name__)

@auth.route('/login', methods=['GET','POST'])
def login():
    return render_template("sesion.html")

@auth.route('/sign-up', methods=['GET','POST'])
def registrar():
    return render_template("registrar.html")