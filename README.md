 CoffeeManagement - Sistema de Gestión de Café
CoffeeManagement es un proyecto escolar desarrollado en Windows Forms utilizando C# como lenguaje de programación, con una base de datos local en MySQL.

 Pantalla Principal (Home)
<img width="959" height="508" alt="image" src="https://github.com/user-attachments/assets/e74ce94f-fbdb-4949-b59c-36a41007552b" />
En la pantalla principal del sistema, se presentan tres opciones:

Buscar clientes

Registrar cliente

Invitado

 Buscar Cliente
<img width="564" height="725" alt="image" src="https://github.com/user-attachments/assets/5e8849fc-6718-4f35-b1d0-9862dbcfe06a" />
Aquí se puede buscar a un cliente previamente registrado ingresando su nombre y apellido.
Al presionar el botón "Buscar cliente", el sistema verificará si existe la cuenta y, de ser así, permitirá proceder con la compra.

En la esquina superior izquierda hay un botón con una flecha roja que sirve para regresar a la pantalla principal.

 Registrar Cliente
<img width="497" height="775" alt="image" src="https://github.com/user-attachments/assets/1a7ecfac-0768-455a-b493-bff527421e19" />
En esta pantalla puedes registrar un nuevo cliente ingresando su nombre y apellido.
Al hacer clic en "Registrar cliente", el usuario queda registrado y puede realizar compras.

También cuenta con el botón de flecha roja para volver a la pantalla principal.

 Ventana de Compra
<img width="980" height="521" alt="image" src="https://github.com/user-attachments/assets/8134bb46-8742-4646-8273-657a40b74f8d" />
Esta pantalla muestra:

Información del cliente: nombre, apellido, número de visitas y cashback (15% del total de la compra).

Total acumulado de los productos seleccionados.

Tres botones para finalizar la compra:

Pagar (verde)

Pagar con cashback (amarillo)

Cancelar (rojo)

A la izquierda, se muestran los productos disponibles con su imagen, nombre y precio.

 Pago
<img width="491" height="541" alt="image" src="https://github.com/user-attachments/assets/802ca354-5a39-47f0-ab9d-abfa4f7db8f6" />
En esta ventana:

Se muestra el total a pagar.

Se ingresa el monto recibido por parte del cliente.

Al presionar el botón "Calcular", el sistema mostrará el cambio correspondiente.

Finalmente, se presiona "OK" para completar el proceso y pasar a la pantalla del ticket.

 Ticket de Compra
<img width="643" height="823" alt="image" src="https://github.com/user-attachments/assets/ff55d8b1-3a7c-431d-a54a-241489095082" />
El ticket generado incluye:

Logo y nombre de la aplicación.

Nombre y apellido del cliente (si está registrado).

Fecha y hora en tiempo real.

Método de pago (efectivo o cashback).

Detalle de la compra (productos, cantidades, precios).

Total de la venta.

Código de barras.

Botón "OK" para finalizar la compra y volver a la pantalla principal.

 Modo Administrador
<img width="620" height="821" alt="image" src="https://github.com/user-attachments/assets/927e4c3d-759d-4fe5-afb9-9587f8a5ec39" />
Este modo solo es accesible para el administrador, quien debe iniciar sesión usando como nombre y apellido "admin".

 Gestión de Precios (Administrador)
<img width="931" height="555" alt="image" src="https://github.com/user-attachments/assets/9824e749-ecbd-4864-9a9a-f48bc9081a49" />
En esta sección, el administrador puede:

Seleccionar el tipo de café.

Asignar un nuevo precio.

Guardar los cambios presionando el botón "Confirmar".

 Funciones Principales
Registro y búsqueda de clientes.

Sistema de cashback automático (15%).

Registro de ventas con ticket detallado.

Gestión de precios exclusiva para administradores.

Manejo de pagos, cambios y cancelaciones.

Base de datos MySQL local.
