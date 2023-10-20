from fastapi import FastAPI
from fastapi.responses import HTMLResponse

app = FastAPI()

@app.get("/", response_class=HTMLResponse)
async def read_root():
    html_content = """
    <!DOCTYPE html>
    <html>
    <head>
        <title>Mi Aplicación FastAPI</title>
    </head>
    <body>
        <header style="background-color: #007BFF; color: white; padding: 20px;">
            <h1 style="text-align: center;">He actualizado main y espero que se genere el cambio</h1>
        </header>
        <div style="margin: 20px;">
            <p style="font-size: 18px; text-align: center;">Esta aplicación fue creada como una prueba de contenedores de Docker.</p>
        </div>

        <div style="text-align: center;">
            <button style="background-color: #007BFF; color: white; padding: 10px 20px; border: none; border-radius: 5px; font-size: 16px; cursor: pointer;">¡Haz clic aquí!</button>
        </div>

        <div style="text-align: center; margin-top: 20px;">
            <img src="301_docker.jpg" alt="Logo de Docker!!!" width="200">
        </div>
    </body>
    </html>

    """
    return HTMLResponse(content=html_content)
