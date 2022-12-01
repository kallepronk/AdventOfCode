#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int main () {
    //Getting the input from the file
    FILE *source;
    source = fopen ("input.txt", "r");
    char buffer[14];
    char list[1010][14];
    int i;
    
    //why the hell do segmentation faults stop when I make the array arbitrarily longer??>????
    while(fgets(buffer, 14, source))
    {
        for (int a = 0; a < 14; a++)
        {
            list[i][a] = buffer[a];
        }
        
        memset(buffer, 0, 14);
        i++;
    }

    fclose(source);

    //Main logic
    
    char oxygen[1010][14] = list;
    char co2[1010][14] = list;
    for (int i = 0; i < 12; i++)
    {
        int zero = 0;
        int one = 0;

        char zeroOxygen[1010][14] = 0;
        char oneOxygen[1010][14] = 0;
        for (int a = 0; a < 1002; a++)
        {
            if(oxygen[a][i] == '1')
            {
                one++;
                for (int y = 0; y < 12; y++)
                {
                    oneOxygen[a][y] = oxygen[a][y];
                }
            }
            if (oxygen[a][i] == '0')
            {
                zero++;
                for (int y = 0; y < 12; y++)
                {
                    zeroOxygen[a][y] = oxygen[a][y];
                }
            }
        }

        if (zero>one)
        {
            oxygen = zeroOxygen;
            
        }
        else{

        }
    }

    for (int i = 0; i < 12; i++)
    {
        printf("%c", gamma[i]);
    }

    printf("   ");

    for (int i = 0; i < 12; i++)
    {
        printf("%c", epsilon[i]);
    }

    
    

    return 0;
}