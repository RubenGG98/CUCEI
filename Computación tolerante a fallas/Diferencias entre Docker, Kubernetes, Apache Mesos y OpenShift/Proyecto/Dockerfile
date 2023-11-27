# Dockerfile
# utiliza una imagen base de python
FROM python:3.8-slim

# establece el directorio de trabajo
WORKDIR /app
# copia los archivos locales al contenedor
COPY app.py .
COPY requiriments.txt .

# instalar las dependencias
RUN pip install -r requiriments.txt

#exponer el puerto en el que se usa la aplicacion Flask 
EXPOSE 5000

#ejecuta la aplicacion al iniciar el contenedor
CMD ["python","app.py"]
