# Coding Kata: Spelling

Write a console program that reads text from `STDIN` and spells it out with a configurable spelling alphabet.

The program shall take as command line argument the file name of a .txt file with the definition of a spelling alphabet as single command line argument.

Two spelling alphabet text files, `icao.txt` and `german.txt` are provided as examples:

[icao.txt](/icao.txt)
```
A	Alfa
B	Bravo
C	Charlie
D	Delta
E	Echo
F	Foxtrot
G	Golf
H	Hotel
I	India
J	Juliett
K	Kilo
...
```

Example program input/output:

```
> spell.exe icao.txt
Hello World
Hotel Echo Lima Lima Oscar Whiskey Oscar Romeo Lima Delta
```
