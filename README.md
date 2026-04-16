# MathClient2

# Aquí tienes el paso a paso detallado para crear el cliente en Visual Studio 2022:

# 1. Crear el Proyecto Cliente
a. Abre Visual Studio 2022 o superior.

b. Selecciona Crear un proyecto.

c. Busca la plantilla Aplicación de consola (.NET Framework).

Nota: Es importante elegir ".NET Framework" y no ".NET Core/6/7/8" para que la compatibilidad con servicios SOAP ASMX sea nativa y sencilla.

d. Ponle un nombre (ej. MathCliente2) y haz clic en Crear.

# 2. Vincular el Web Service (El paso clave)
Como estamos usando un servicio .asmx, no basta con añadir una "Service Reference" común. Sigue esta ruta:

1. En el Explorador de Soluciones, haz clic derecho sobre el nombre de tu proyecto.

2. Selecciona Agregar > Referencia de servicio... (Service Reference).

Se abrirá una ventana. No busques el servicio ahí. Haz clic en el botón inferior que dice Enviar... o Avanzado... (Advanced).

3. En la nueva ventana que aparece, haz clic en el botón inferior que dice Agregar referencia web... (Add Web Reference). Esta es la opción para servicios clásicos.

4. En el cuadro de URL, pega la dirección donde se está ejecutando tu Web Service (ejemplo: https://localhost:44321/MathService.asmx).

5. Visual Studio buscará el servicio y mostrará los métodos disponibles (como VerificarSaldoParaCompra).

6. En Nombre de referencia web, cámbialo a MathService.

7. Haz clic en Agregar referencia.

8.Ejecuta el webservice MathCliente2 


