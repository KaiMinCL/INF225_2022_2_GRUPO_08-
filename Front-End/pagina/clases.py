from flask_login import UserMixin
#Creamos clases que sean compatibles con las funciones de flask_login para manejar las sesiones de los usuarios
class Client(UserMixin):
    def __init__(self, id, nombre, rut, contrasena):
        self.id = id
        self.nombre = nombre
        self.rut = rut
        self.pwd = contrasena

class Staff(UserMixin):
    def __init__(self, id, nombre, tienda, contrasena):
        self.id = id
        self.nombre = nombre
        self.pwd = contrasena
        self.iD_tienda = tienda
    
    def get_tienda(self):
        return self.iD_tienda