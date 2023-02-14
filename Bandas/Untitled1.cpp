#include <stdio.h>
#include <stdlib.h>
 
 
 
 
 
void color_numero();
void numero_color();
 
 
int main(){
int opcion;
 
printf("1.-Ingresar colores y mostrar valor de resistencia\n2.-Ingresar valor de resistencia y mostrar colores\n");
scanf("%d",&opcion);
 
switch(opcion){
case 1:
color_numero();
break;
 
case 2:
numero_color();
break;
 
 
default:
printf("Opcion no valida\n");
break;
}
 
}
 
void color_numero(){
char colores[3];
int valor;
printf("N=negro\nM=marron\nR=rojo\nn=naranja\nA=am arillo\nV=verde\na=azul\nv=vilotA\nG=gris\nB=blanc o\n");
printf("Ingresa las inicales de los colores de las resistencias: \n");
scanf("%s",colores);
//evaluamos el primer elemento del arreglo comparandolo con las letras que representan cada color
switch(colores[0]){
case 'N':
valor=0;
break;
case 'M':
valor=10;
break;
case 'R':
valor=20;
break;
case 'n':
valor=30;
break;
case 'A':
valor=40;
break;
case 'V':
valor=50;
break;
case 'a':
valor=60;
break;
case 'v':
valor=70;
break;
case 'G':
valor=80;
break;
case 'B':
valor=90;
break;
default:
printf("Opcion invalida");
break;
 
 
 
 
}
//evaluamos el segundo elemento
switch(colores[1]){
case 'N':
valor+=0;
break;
case 'M':
valor+=1;
break;
case 'R':
valor+=2;
break;
case 'n':
valor+=3;
break;
case 'A':
valor+=4;
break;
case 'V':
valor+=5;
break;
case 'a':
valor+=6;
break;
case 'v':
valor+=7;
break;
case 'G':
valor+=8;
break;
case 'B':
valor+=9;
break;
default:
printf("Opcion invalida");
break;
}
//evaluamos el tercer elemento que es el multiplicador
switch(colores[2]){
case 'N':
valor*=1;
break;
case 'M':
valor*=10;
break;
case 'R':
valor*=100;
break;
case 'n':
valor*=1000;
break;
case 'A':
valor*=10000;
break;
case 'V':
valor*=100000;
break;
case 'a':
valor*=1000000;
break;
 
default:
printf("Opcion invalida");
break;
 
 
}
//se imprime el valor
printf("El valor de la resistencia es: %d K Ohms\n",valor);
 
 
 
 
}
 
 
 
void numero_color(){
char color[3];//arreglo donde se iran guardando los colores
int valor,b1,b2,multiplicador;//variables donde se guardaran los valores de las bandas y el valor total de la resistencia
printf("Ingresa el valor de la resistencia en Ohms:");
scanf("%d",&valor);
for(multiplicador=1;valor>=100;multiplicador++){
valor=valor/10;
 
}
 
b1=valor/10;
b2=(valor-(10*b1));
printf("%d %d\n",b1,b2);
switch(b1){//aqui se busca el color de la banda 1
 
case 1:
color[0]='M';
break;
 
case 2:
color[0]='R';
break;
 
case 3:
color[0]='n';
break;
 
case 4:
color[0]='A';
break;
 
case 5:
color[0]='V';
break;
 
case 6:
color[0]='a';
break;
 
case 7:
color[0]='v';
break;
case 8:
color[0]='G';
break;
 
case 9:
color[0]='B';
break;
 
default:
printf("Opcion invalida");
break;
}
switch(b2){//aqui se busca el color de la banda 2
case 0:
color[1]='N';
break;
 
case 1:
color[1]='M';
break;
 
case 2:
color[1]='R';
break;
 
case 3:
color[1]='n';
break;
 
case 4:
color[1]='A';
break;
 
case 5:
color[1]='V';
break;
 
case 6:
color[1]='a';
break;
 
case 7:
color[1]='v';
break;
case 8:
color[1]='G';
break;
 
case 9:
color[1]='B';
break;
 
default:
printf("Opcion invalida");
break;
}
 
switch(multiplicador){//aqui se busca el color de la banda multiplicadora
case 1:
color[2]='N';
break;
 
case 2:
color[2]='M';
break;
 
case 3:
color[2]='R';
break;
 
case 4:
color[2]='n';
break;
 
case 5:
color[2]='A';
break;
 
case 6:
color[2]='V';
break;
 
case 7:
color[2]='a';
break;
 
 
default:
printf("Opcion invalida");
break;
}
 
 
printf("Los colores correspondientes a este valor son: \n%s\n",color);
printf("\tTabla de colores:\nN=negro\nM=marron\nR=rojo\nn=naranja\nA= amarillo\nV=verde\na=azul\nv=vilotA\nG=gris\nB=bla nco\n");
}
