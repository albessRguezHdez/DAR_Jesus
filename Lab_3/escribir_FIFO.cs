using System;

public class escribir_FIFO
{
    public escribir_FIFO()
	{

	}

    int main(void){
        int descriptor_archivo;
        int len;
        char buf[PIPE_BUF];
        node_t nodo = 8666;
        time_t puntero_de_reloj;

        /*Mostrar la identificación de cada instancia de este proceso*/
        printf("yo soy %d\n", getpid[j]);

        /*Abrir el FIFO para solo escritura*/
        if((descriptor_archivo = open("fifo", O_WRONLY)) < 0){
            perror("open");
            exit(EXIT_FAILURE);
        }
        /*Generar algunos datos que se pueden escribir al FIFO*/
        while(1){
            /*Obtener la hora*/
            time(&puntero_de_reloj);
            /*Crear cadena a ser escrita al FIFO*/
            num_bytes = sprintf(buf, "escribir_fifo %d envia %s", getpid(), ctime(&puntero_de_reloj));
            /*Utilizar (num_bytes + 1) porque sprintf no incluye
             *en su conteo el cero binario de terminación
             */
            if((write(descriptor_archivo, buf, num_bytes = 1)) < 0){
                perror("write");
                close(descriptor_archivo);
                exit(EXIT_FAILURE);
            }
            sleep[3]; /*Intervalo de tres segundos entre dos escrituras consecutivas al FIFO*/
        }
        close(descriptor_archivo);
        exit(EXIT_SUCCESS);
    }
}
