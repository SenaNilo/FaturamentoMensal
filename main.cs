using System;

class Program {
  public static void Main (string[] args) {
    /*
      SP – R$67 836,43 = [0]
      RJ – R$36 678,66 = [1]
      MG – R$29 229,88 = [2]
      ES – R$27 165,48 = [3]
      Outros – R$19 849,53 = [4]
    */
    double[] estado = new double[5];
    double[] porcentagem = new double[5];
    double somatoria=0;
    int i;
    
    estado[0] = 67836.43; //SP
    estado[1] = 36678.66; //RJ
    estado[2] = 29229.88; //MG
    estado[3] = 27165.48; //ES
    estado[4] = 19849.53; //Outros
    
    for ( i=0; i<5; i++){
      somatoria = somatoria + estado[i];
    }
    for(i = 0; i<5; i++){
      porcentagem[i] = estado[i]*100/somatoria;
    }
    Console.WriteLine("Percentual de SP = {0:F2}%",porcentagem[0]);
    Console.WriteLine("Percentual do RJ = {0:F2}%",porcentagem[1]);
    Console.WriteLine("Percentual de MG = {0:F2}%",porcentagem[2]);
    Console.WriteLine("Percentual do ES = {0:F2}%",porcentagem[3]);
    Console.WriteLine("Percentual de Outros = {0:F2}%",porcentagem[4]);
    Console.WriteLine("Valor total da distribuidora = R${0}",somatoria);
  }
}