function initializeOdometers(escaleraReal, escaleraColor) {
    const odometer1 = new Odometer({
        el: document.getElementById('odometer1'),
        value: escaleraReal,
        format: '(.ddd),dd' // Formato con comas y decimales
    });

    const odometer2 = new Odometer({
        el: document.getElementById('odometer2'),
        value: escaleraColor,
        format: '(.ddd),dd'
    });

     //Incrementar automáticamente después de un intervalo si es necesario
    setInterval(() => {
        odometer1.update(escaleraReal += 7.5);
        odometer2.update(escaleraColor += 5.5);
    }, 3000);
}
