#include <stdio.h>
#include <stdlib.h>

int main () {
    //Getting the input from the file
    FILE *source;
    source = fopen ("Day1Input.txt", "r");
    int count = 0;
    int list[2000];
    int firstNumber;
    int i;

    while(!feof(source))
    {
        fscanf(source, "%d", &list[i]);
        i++;
    }

    //Main logic
    
    firstNumber = list[0];

    for(int a = 1; a<2000; a++)
    {
        if(list[a]> firstNumber)
        {
            count++;
        }
        firstNumber = list[a];
    }
    
    printf("%d\n", count);
    fclose(source);
    return 0;
}