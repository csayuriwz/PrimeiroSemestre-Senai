﻿//Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos.
//Imprima o resultado no console

Console.WriteLine($"Digite sua idade");
int idade = int.Parse(Console.ReadLine());

int meses = idade*12;
int dias = idade*365;
int horas = dias*24;
int minutos = horas*60;

Console.WriteLine($"a quantidade de meses é {meses}");

Console.WriteLine($"a quantidade de dias é {dias}");

Console.WriteLine($"a quantidade de horas é {horas}");

Console.WriteLine($"a quantidade de minutos é {minutos}");



