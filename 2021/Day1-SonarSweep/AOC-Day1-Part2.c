#include <stdio.h>
#include <stdlib.h>

int main () {
    //Getting the input from the file
    FILE *source;
    source = fopen ("Day1Input.txt", "r");
    int count = 0;
    int list[2000];
    int firstNumber;
    int secondNumber;
    int thirdNumber;
    int previousCluster;
    int currentCluster;
    int i;

    while(!feof(source))
    {
        fscanf(source, "%d", &list[i]);
        i++;
    }

    // Main Logic
    previousCluster = list[0] + list[1] + list[2];

    firstNumber = list[0];
    secondNumber = list[1];
    thirdNumber = list[2];

    for(int a = 3; a<2000; a++)
    {
        currentCluster = secondNumber + thirdNumber + list[a];
        if(currentCluster>previousCluster)
        {
            count++;
        }
        previousCluster = currentCluster;
        secondNumber = thirdNumber;
        thirdNumber = list[a];
    }

    printf("%d\n", count);
    fclose(source);
    return 0;
}