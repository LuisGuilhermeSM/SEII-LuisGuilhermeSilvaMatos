
APPS = ./apps
BIN = ./bin
INCLUDE = ./include
OBJ = ./obj
SCR = ./scr


all: libed myapps
	
libed: \
	float_vector.o \
	mytime.o

myapps:
	gcc $(APPS)/app.c $(OBJ)/float_vector.o -I $(INCLUDE) -o $(BIN)/app
	gcc $(APPS)/app_com_mytime.c $(OBJ)/*.o -I $(INCLUDE) -o $(BIN)/app_com_mytime

#Exemplo da aplicação da target abaixo:
#	make float_vector.o
#	% ==> float_vector
#	float_vector.o: $(SCR)/float_vector.c $(INCLUDE)/float_vector.h
#	$< ==> Primeiro prerequisito do target, no caso $< = $(SCR)/%.c = $(SCR)/float_vector.c = ./scr/float_vector.c
#	$@ ==> Nome do target, no caso $@ = %.o = float_vector.o
#	Resultando em: gcc -c $< -I $(INCLUDE) -o $(OBJ)/$@ = gcc -c $(SCR)/float_vector.c -I $(INCLUDE) -o $(OBJ)/float_vector.o 
%.o: $(SCR)/%.c $(INCLUDE)/%.h
	gcc -c $< -I $(INCLUDE) -o $(OBJ)/$@

run:
	./bin/app

clean:
	rm -rf ./bin/* ./obj/*.o


