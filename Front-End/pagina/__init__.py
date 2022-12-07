from flask import Flask
from flask_login import LoginManager
import requests

def create_app():
    app = Flask(__name__)
    app.config['SECRET_KEY'] = 'fshjgdfdsnmgdsfmng'
    from .views import views
    from .auth import auth
    app.register_blueprint(views, url_prefix='/')
    app.register_blueprint(auth, url_prefix='/')
    from .clases import Client, Staff
    login_manager = LoginManager()
    login_manager.login_view = 'auth.login'
    login_manager.init_app(app)

    @login_manager.user_loader
    def load_user(id): #A partir de id encontrar el usuario al que prertenece
        #Buscar entre los clientes
        Clients = requests.get('http://localhost:5058/Clientes')
        clientsjson = Clients.json()
        for client in clientsjson:
            if client['iD_Cliente'] == int(id):
                cclient = Client(client['iD_Cliente'], client['nombre'], client['rut'], client['contrasena'])
                return cclient
        #Buscar entre el Staff
        rstaff = requests.get('http://localhost:5058/STAFF')
        staffjson = rstaff.json()
        for staff in staffjson:
            if staff['iD_STAFF'] == int(id):
                cstaff = Staff(staff['iD_STAFF'], staff['nombre'], staff['usuario'], staff['iD_Tienda'], staff['contrasena'])
                return cstaff
        #Retornar None si es que no es encontrado el usuario
        return None
    return app
