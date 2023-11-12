''''
Gutierrez Galan Ruben Alejandro codigo: 214798315
Computación Tolerante a fallas
2023B
Arquitecturas monolíticas vs Microservicios
Michel Emanuel López Franco

'''

# app.py
from flask import Flask, request, jsonify

app = Flask(__name__)

def guardar_resultado(resultado_decimal, resultado_hexa):
    with open('resultados.txt', 'a') as file:
        file.write(f"Decimal: {resultado_decimal}, Hexadecimal: {resultado_hexa}\n")
    file.close()

@app.route('/calcular', methods=['POST'])
def calcular():
    data = request.get_json()

    operacion = data['operacion']
    numero1 = data['numero1']
    numero2 = data['numero2']

    if operacion == 'sumar':
        resultado = numero1 + numero2
    elif operacion == 'restar':
        resultado = numero1 - numero2
    elif operacion == 'multiplicar':
        resultado = numero1 * numero2
    elif operacion == 'dividir':
        if not isinstance(numero1, (int, float)) or not isinstance(numero2, (int, float)):
            return jsonify({"error": "Los números deben ser enteros o de punto flotante"}), 400
        if numero2 != 0:
            resultado = numero1 / numero2
        else:
            return jsonify({"error": "No se puede dividir por cero"}), 400
    else:
        return jsonify({"error": "Operación no válida"}), 400
    resultado=int(resultado)
    resultado_hexa = hex(resultado)  # Convierte el resultado a hexadecimal
    guardar_resultado(resultado, resultado_hexa)  # Guarda el resultado en el archivo

    return jsonify({"resultado": resultado, "resultado_hexa": resultado_hexa})


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0')
