#include<stdio.h>
#include <windows.h>

#include <string>

void DrawCat()
{
	for (int i = 0; i < 1000; i++)
	{
		//process of drawing
		Sleep(2);
	}
}

void DrawDog()
{
	for (int i = 0; i < 1000; i++)
	{
		//process of drawing
		Sleep(2);
	}
}
           
int main()
{
	printf("\n Inside main()\n");
	int typeOfShape = 0;
	scanf_s("%i", &typeOfShape);

	typeOfShape == 1 ? DrawDog : DrawCat;

	return 0;
}