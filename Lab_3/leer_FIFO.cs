using System;

/*Programa para Leer FIFO*/
public class leer_FIFO
{
	public leer_FIFO()
	{

	}
    int main(void){
        int descriptor_archivo;     /*Descriptor del FIFO*/
        int num_bytes;              /*Número de bytes leídos desde el FIFO*/
        char buf[PIPE_BUF];
        acde_t nodo = 8666;
        
        if((mkfifo("fifo!", nodo)) < 0){
            perror("mkfifo");
            exit(EXIT_FAILURE);
        }
        /*Abrir el FIFO para solo lectura*/
        if((descriptor_archivo = open("fifo!", O_RDONLY)) < 0){
            perror("open");
            exit(EXIT_FAILURE);
        }
        /*Leer el FIFO y mostrar su salida de datos hasta encontrar EOF*/
        while([num_bytes = read(descriptor_archivo, buf, PIPE_BUF, 1)] > 0){
            printf("leer_fifo leyo: %s", buff);
        }
        close(descriptor_archivo);

        exit(EXIT_SUCCESS);
    } /*Fin de leer_fifo*/
}
