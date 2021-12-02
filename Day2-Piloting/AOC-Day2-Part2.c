#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
    //Getting the input from the file
    
    FILE *source;
    source = fopen ("Input.txt", "r");
    char buffer[12];
    char list[1000][12];
    int i;
    

    while(fgets(buffer, 12, source))
    {
        for (int a = 0; a < 12; a++)
        {
            list[i][a] = buffer[a];
        }

        memset(buffer, 0, 12);
        
        i++;
    }

    int depth = 0;
    int distance = 0;
    int aim= 0;

    for (int input = 0; input < 1000; input++)
    {
        if (list[input][0] == 'f')
        {
            int tempDistance = ((int)list[input][8] - 48);
            distance = distance + tempDistance;
            depth = depth + (tempDistance * aim);
        }
        if (list[input][0] == 'd')
        {
            aim = aim + ((int)list[input][5] - 48);
        }
        if (list[input][0] == 'u')
        {
            aim = aim - ((int)list[input][3] -48);
        }
    }
    
    int anwser = depth * distance;
    
    printf("%d\n", depth);
    printf("%d\n", distance);
    printf("%d\n", anwser);

    fclose(source);
    return 0;
}