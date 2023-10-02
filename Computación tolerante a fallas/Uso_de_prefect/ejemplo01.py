import prefect
from prefect import task, Flow

@task
def hello_task():
    return "Hola, mundo!"

with Flow("MiFlujoDeTrabajo") as flow:
    resultado = hello_task()

flow.run()
