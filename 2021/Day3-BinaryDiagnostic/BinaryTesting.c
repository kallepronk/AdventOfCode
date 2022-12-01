#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main ()
{
   /* int test =0;
    test ^=1;
    test <<=1;
    test <<=1;
    test ^=1;
    printf("%d\n", test);

    char * arr = "Hello";

    while (*arr)
    {
        printf("%c\n", *arr);
    }*/
    int size = 5;
    char arr[size];
    arr[0] = '0';
    arr[1] = '1';
    arr[2] = '0';
    arr[3] = '1';

    
    char* start = &arr[0];
    int total = 0;
    int i = 1;

    while (i < size)
    {
        total <<=1;
        if(*start++ == '1'){
            total ^= 1;
        }
        i++;
    }
    printf("%d\n", total);
    
    return 0;
}