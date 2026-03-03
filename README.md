Optimización de Elementos para Excursionistas
📝 Descripción del Problema
Software diseñado para determinar el conjunto de elementos óptimos (Id, Peso, Calorías) que un excursionista debe llevar, asegurando que se cumpla con un mínimo de calorías requerido y se respete un peso máximo permitido.
⚙️ Tecnologías Utilizadas

    Backend: .NET 8 (C#) - Web API.
    Frontend: HTML5, Bootstrap 5, JavaScript (Vanilla).
    Comunicación: JSON vía REST API.

🚀 Cómo ejecutar la aplicación

    Backend:
        Navega a la carpeta del proyecto desde la terminal.
        Ejecuta el comando: dotnet run. (en algunos casos es necesario correr dotnet build)
        El servidor iniciará por defecto en http://localhost:5050.
    Frontend:
        Abre el archivo index.html en cualquier navegador moderno.
        Ingresa los valores (Ej: 15 cal, 10 peso) y presiona "Calcular".

📡 Comunicación Front-Back
La aplicación utiliza un modelo interoperable donde el Frontend y el Backend están desacoplados:

    El Frontend recolecta los datos y envía un objeto JSON mediante una petición fetch con el método POST.
    El Backend recibe el JSON, ejecuta el algoritmo de optimización y devuelve una respuesta estructurada en JSON con la lista de objetos seleccionados y los totales calculados.
    El Frontend procesa la respuesta y genera dinámicamente el HTML para mostrar los elementos uno por uno.

📈 Escalabilidad y Futuro
Actualmente, el sistema utiliza un algoritmo de fuerza bruta (Power Set), el cual es eficiente para la lista actual de 5 elementos. Para escalar a miles de elementos en el futuro, se proponen las siguientes mejoras:

result :
<img width="1913" height="981" alt="image" src="https://github.com/user-attachments/assets/38e3faff-5c5b-49b6-a3b2-eaab474ca06c" />


    Programación Dinámica: Implementar el algoritmo de la "Mochila" (Knapsack Problem) para reducir la complejidad computacional.
    Persistencia de Datos: Migrar los elementos de una lista estática a una base de datos SQL/NoSQL.
    Paginación y Filtros: Permitir la gestión de grandes volúmenes de elementos desde la interfaz de usuario.

---
