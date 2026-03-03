async function calcularOptimización() {
    const payload = {
        minCalorias: parseInt(document.getElementById('minCal').value),
        maxPeso: parseInt(document.getElementById('maxPeso').value),
        elementos: [
            { id: "E1", peso: 5, calorias: 3 },
            { id: "E2", peso: 3, calorias: 5 },
            { id: "E3", peso: 5, calorias: 2 },
            { id: "E4", peso: 1, calorias: 8 },
            { id: "E5", peso: 2, calorias: 3 }
        ]
    };

    try {
        const response = await fetch('http://localhost:5050/api/excursion/optimizar', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(payload)
        });

        if (response.ok) {
            const data = await response.json();
            const detDiv = document.getElementById('detalleResultado');
            document.getElementById('resultado').classList.remove('d-none');

            let html = "<ul>";
            data.elementos.forEach(el => {
                html += `<li><strong>${el.id}</strong>: Peso ${el.peso}, Calorías ${el.calorias}</li>`;
            });
            html += "</ul>";
            html += `<p class="mt-3"><strong>Peso Total: ${data.pesoTotal}</strong></p>`;
            html += `<p><strong>Calorías Totales: ${data.caloriasTotales}</strong></p>`;

            detDiv.innerHTML = html;
        }
    } catch (error) {
        alert("Error al conectar con el servidor.");
    }
}