/* ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Crie um programa que simula
o treinamento de um Jedi. O usuário deve
inserir o número de horas de treinamento
por dia. O programa deve calcular o total
de horas de treinamento em uma semana,
desconsiderando sábados e domingos, e
informar quantos dias, semanas e meses
seriam necessários para alcançar o total de
1000 horas de treinamento. Considere 1
mês = 4,5 semanas.
*/
#include <iostream>
using namespace std;

int main()
{
    int horasPorDia, totalHoras = 0;
    cout << "Digite o número de horas de treinamento por dia: ";
    cin >> horasPorDia;

    totalHoras = horasPorDia * 5;

    int diasNecessarios = 1000 / horasPorDia;
    int semanasNecessarias = diasNecessarios / 5;
    int mesesNecessarios = semanasNecessarias / 4.5;

    cout << "Total de horas de treinamento em uma semana: " << totalHoras << endl;
    cout << "Seriam necessários " << diasNecessarios << " dias, " 
         << semanasNecessarias << " semanas e " 
         << mesesNecessarios << " meses para alcançar 1000 horas." << endl;

    return 0;
}
