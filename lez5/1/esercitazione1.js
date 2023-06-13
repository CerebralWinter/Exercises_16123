//btn è un oggetto html element (HTMLButtonElement)
const btn = document.getElementById("btn");
//testo è un oggetto html element (HTMLParagraphElement)
const testo = document.getElementById("testo");

//textContent è una proprietà dell'oggetto HTML element
btn.addEventListener("click", function() {
    testo.textcontent = "Hai cliccato sul bottone!"; 
});