from pagina import create_app

app = create_app()

if __name__ == '__main__': #Solo correr la app si se ejecuta este archivo
    app.run(debug=True) #Cargar automáticamente cambios