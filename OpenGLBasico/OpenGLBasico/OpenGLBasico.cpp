// Simple.cpp
// The Simplest OpenGL program with GLUT
// OpenGL SuperBible, 3rd Edition
// Richard S. Wright Jr.
// rwright@starstonesoftware.com
// Updated by
// Leandro Tonietto
// ltonietto@unisinos.br

#include "stdafx.h"
#include <windows.h>		// Must have for Windows platform builds
#include <GL/gl.h>
#include <GL/glu.h>
#include <glut.h>
#include <iostream>
#include <math.h>

#define PI 3.1415926535898
float angle;
float blue = 1.0;
int arc = 0;

using namespace std;

///////////////////////////////////////////////////////////
// Called to draw scene
void RenderScene(void) {
	// Clear the window with current clearing color
	glClear(GL_COLOR_BUFFER_BIT);

	// define mode de desenho do polígono
	glPolygonMode(GL_FRONT, GL_LINE);
	// define espessura da linha
	glLineWidth(1.5f); // isto poderia ser feito em outro local?

	// desenho de polígonos complexos

	// Draw in Blue
	glPushMatrix();
	glRotatef(angle, 0, 0, 1);

	glColor3f(0.0f, 0.0f, 1.0f);
	glBegin(GL_POLYGON);
		glVertex3f(-2, 0, 0);
		glVertex3f(2, 3, 0);
		glVertex3f(0, 0, 0);
		glVertex3f(1, -4, 0);
	glEnd();
	glPopMatrix();
	glColor3f(0.0f, 1.0f, 1.0f);
	glBegin(GL_POLYGON);
		glVertex3f(-2.5, 0, 0);
		glVertex3f(-4, 3, 0);
		glVertex3f(-6, 0, 0);
		glVertex3f(-6.5, -2.5, 0);
		glVertex3f(-4.2, -1, 0);
		glVertex3f(-2.7, -2.5, 0);
	glEnd();
	

	// desenho de elipse
	
	glPolygonMode(GL_FRONT, GL_FILL);
	GLfloat circle_points = 100 - arc;
	GLfloat angle=0.0f;
	GLfloat raioX = 4;//1 + (float)(rand() % 5);
	GLfloat raioY = 4;//1 + (float)(rand() % 5);
	glColor3f(0.0f, 0.0f, blue);
	glBegin(GL_POLYGON);
	for (int i = 0; i < circle_points; i++) {
		angle = 2*PI*i/circle_points;
		glVertex2f(3+cos(angle)*raioX, 3+sin(angle)*raioY);
	}
	glEnd();
	glColor3f(1.0f, 0.0f, 0.0f);
	glPointSize(2.0f);
	glEnable(GL_POINT_SMOOTH);
	glBegin(GL_POINTS);
	for (int i = 0; i < circle_points; i++) {
		angle = 2*PI*i/circle_points;
		glVertex2f(3+cos(angle)*raioX, 3+sin(angle)*raioY);
	}
	glEnd();

	// Flush drawing commands
    glFlush();
	// glutSwapBuffers();
}


///////////////////////////////////////////////////////////
// Called to handle a keyboard event
// Função deve receber um char da tecla pressionada,
// e um x e y
void keyboard (unsigned char key, int x, int y) {
	switch (key) {
		case 'Q':
		case 'q':
			exit(0);

		case '+':
			blue += 0.1;
			blue = min(1.0, blue);
			break;
		case '-':
			blue -= 0.1;
			blue = max(0.0, blue);
			break;

		case 'a':
			arc += 10;
			arc = min(100, arc);
			break;
		case 'z':
			arc -= 10;
			arc = max(0, arc);
	}
	glutPostRedisplay();
}


///////////////////////////////////////
// Set 2D Projection Ð negative 10 to positive 10 in X and Y
// Função deve receber sempre dois inteiros
void ChangeSize(int w, int h)
{
	// Prevent a divide by zero
	if(h == 0) h = 1;

	// Set Viewport to window dimensions
	glViewport(0, 0, w, h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();

	gluOrtho2D(-10.0f, 10.0f, -10.0f, 10.0f);

	// Modelview matrix reset
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();

	angle += 10.0f;
}


///////////////////////////////////////////////////////////
// Setup the rendering state
void init(void){
    glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
	angle = 90.0;
	// configuração padrão 
	// inicial de iluminação e câmera
	// etc.
}


///////////////////////////////////////////////////////////
// Main program entry point
int main(int argc, char* argv[]) {
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_SINGLE | GLUT_RGBA);
 	int id = glutCreateWindow("Primeiro exemplo OpenGL");

	// definição de funções de call-back
	glutDisplayFunc(RenderScene);
	glutReshapeFunc(ChangeSize);
	glutKeyboardFunc(keyboard);

	// inicializações e definições constantes
	init();

	// inicio do pipe-line OpenGL
	glutMainLoop();
   
    return 0;
}

