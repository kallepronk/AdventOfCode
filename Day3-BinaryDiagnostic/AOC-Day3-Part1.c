#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "CharArrayToInt.h"


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
    
    char gamma[12];
    char epsilon[12];
    for (int i = 0; i < 12; i++)
    {
        int zero = 0;
        int one = 0;
        for (int a = 0; a < 1002; a++)
        {
            if(list[a][i] == '1')
            {
                one++;
            }
            if (list[a][i] == '0')
            {
                zero++;
            }
        }

        if (zero>one)
        {
            gamma[i] = '0';
            epsilon[i] = '1';
        }
        else{
            gamma[i]='1';
            epsilon[i]='0';
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

    printf("Gamma: %d\n", CharArrayToInt(gamma, 13));
    printf("Epsilon: %d\n", CharArrayToInt(epsilon, 13));

    
    

    return 0;
}