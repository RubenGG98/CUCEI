import os
import shutil
from prefect import Flow, task

# Define una tarea para copiar archivos
@task
def copy_files(source_folder, destination_folder):
    try:
        # Verifica si la carpeta de destino existe; si no, créala
        if not os.path.exists(destination_folder):
            os.makedirs(destination_folder)

        # Lista todos los archivos en la carpeta de origen
        files = os.listdir(source_folder)

        # Copia cada archivo de la carpeta de origen a la de destino
        for file in files:
            source_path = os.path.join(source_folder, file)
            destination_path = os.path.join(destination_folder, file)
            shutil.copy2(source_path, destination_path)

        return f"Copied {len(files)} files from {source_folder} to {destination_folder}"
    except Exception as e:
        return f"Error: {str(e)}"

# Define el flujo principal
with Flow("FileCopyFlow") as flow:
    source_folder = "D:/Programacion/Classroom/Computacion_Tolerante_a_fallas_1/Workflow managers/Uso_de_prefect/Origen"
    destination_folder = "D:/Programacion/Classroom/Computacion_Tolerante_a_fallas_1/Workflow managers/Uso_de_prefect/Destino"
    
    copy_task = copy_files(source_folder, destination_folder)

# Ejecuta el flujo
if __name__ == "__main__":
    flow.run()
