/*Faça um programa que contenha a classe automóvel com um atributo combustível e duas classes que herdam desta
Esportivo e Caminhão e um programa que receba um Esportivo ou um caminhão e retorne o combustível correspondente,
a saber: Esportivo utiliza Gasolina e Caminhão utiliza Diesel.*/

public class Main 
{
    public static void main(String[] args) 
    {
        Esportivo esportivo = new Esportivo();
        esportivo.receberCombustivel();

        Caminhao caminhao = new Caminhao();
        caminhao.receberCombustivel();
    }
}
