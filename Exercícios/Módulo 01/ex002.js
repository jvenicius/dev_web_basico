class Pessoa{
    constructor(nome){
        this.nome = nome;
    }

    falar(frase){
        console.log(this.nome + " disse: " + frase);
    }
}

class Aluno extends Pessoa{
    estudar(disciplina){
        console.log(this.nome + " estuda " + disciplina);
    }
}

class Professor extends Pessoa{
    ensinar(disciplina){
        console.log(this.nome + " ensina " + disciplina);
    }

    falar(frase){
        console.log(this.nome + " FALA ALTO: " + frase);
    }
    
    falar(frase, quantidade){
        console.log(this.nome + " FALA " + quantidade + " VEZES MAIS ALTO: " + frase);
    }
}


var p1 = new Pessoa("Venícius");
var p2 = new Aluno("Sofia")
var p3 = new Professor("Venícius")

p1.falar("Oi, tudo bem?")
p2.estudar("Habilidades Digitais")
p3.ensinar("Habilidades Digitais")
p3.falar("Silêncio!!!")
p3.falar("Silêncio!!!", 3)