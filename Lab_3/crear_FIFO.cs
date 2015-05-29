using System;

/*Programa para Crear FIFO*/
public class crear_FIFO
{
	public crear_FIFO()
	{
           
	}
     int main(int argc, char *argv[]){
         node_t nodo = 8666;
         if(argc != 2){
            /*El nombre del programa se cuenta como argumento*/
             puts("Modo de empleo:nuevofifo <nombre_de_fifo> ");
             exit[EXIT_FAILURE];
         }
         if((mkfifo(argv[1], nodo)) < 0){
             perror("mkfifo");
             exit[EXIT_FAILURE];
         }
         exit[EXIT_SUCCESS];
     }
}
