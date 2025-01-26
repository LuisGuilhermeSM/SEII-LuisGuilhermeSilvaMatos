
APPS = ./apps
BIN = ./bin
INCLUDE = ./include
OBJ = ./obj
SCR = ./scr


all:
	gcc -c $(SCR)/float_vector.c -I $(INCLUDE) -o $(OBJ)/float_vector.o
	gcc -c $(SCR)/mytime.c -I $(INCLUDE) -o $(OBJ)/mytime.o
	gcc $(APPS)/app.c $(OBJ)/float_vector.o -I $(INCLUDE) -o $(BIN)/app
	gcc $(APPS)/app_com_mytime.c $(OBJ)/*.o -I $(INCLUDE) -o $(BIN)/app_com_mytime

run:
	./bin/app

clean:
	rm ./bin/* ./obj/*.o


