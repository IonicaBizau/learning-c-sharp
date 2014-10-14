## Instrucțiuni de control

1. Minimul și maximul a două numere

2. Să se verifice dacă un număr real `x` se află în intervalul `[a, b)`.

3. Ecuația de gradul I (ax + b = 0)

4. Ecuația de gradul al II-lea.

5. Să se verifice dacă trei numere date sunt consecutive

6. Să se verifice dacă un număr este pătrat perfect.

7. Se dau trei numere reale `a`, `b`, `c` -- să se determine dacă pot reprezenta lungimile laturilor unui triunghi și în caz afirmativ să se precizeze tipul triunghiului (echilateral, isoscel, oarecare).
(`a, b, c > 0`, `x + y > z`)

8. `a`, `b` -- c.m.m.d.c, c.m.m.c

9. `1 <= x <= 7` să se afișeze ziua din săptămână corespunzătoare

10. Afișarea numerelor n -> m, (des)crescătoare, while, constante simbolice

11. Copierea instrării în ieșire -- câte un cuvânt pe un rând, cu litere mici

12. Se citește un text de la tastatură: să se contorizeze:

 - caracterele
 - liniile
 - spațiile albe (spațiu, tab, new line)
 - cuvintele

13. Jocul ghicește numărul: se generează un număr random, utilizatorul introduce numere până îl ghicește ajutat de mesaje de genul: "Mai mic", "Mai mare"

14. Calculați suma `1 - 2 + 3 - 4 + ... +/- n` pentru `n`.

15. Să se verifice dacă un număr citit este:

 - (im)par
 - divizibil cu `7`
 - prim

## Funcții

1. Minimul și maximul a trei numere (func: min, max a două numere)

2. Primele n numere prime

3. Să se scrie o funcție care determină numărul triunghi al unui număr dat (n(n+1)/2)

4. Factorial nerecursiv

5. Să se descompună în factori primi un număr dat `n`.

6. Afișarea unui număr în ordine inversă a cifrelor

7. Modifcă valorile a trei parametri de tip șir de caractere (parametri valoare, referință, out)

8. Interschimbare a două variabile utilizând atât parametri valoare/referință

## Funcții recursive

1. Calculul combinărilor recursiv

```
1, k = 1
n, k = n
C(n - 1, k - 1) + C(n - 1, k - 1)
```

2. n! rec

3. n - Fibonacci

4. `2 <= n <= 255` - toate numerele prime mai mici decât `n` fără a folosi operatorii `*`, `/`, `%` (algoritmul lui Ratostene)

5. Determinarea c.m.d.c (rec)

6. Calculul determinantului unei matrici pătratice prin dezvoltarea pe linie. :exclamation:

## Tablouri

1. Citiri și afișări (uni|big)dimensionale

2. Căutarea binară într-un vector sortat (rec)

3. Căutarea binară într-un vector sortat (nerec)

4. Intersecția a doi vectori

5. Citirea mai multor linii, afișarea celei mai lungi

6. Random values in array, sort asc -- bubble sort

7. Random values in array, sort desc -- quick sort

8. Random password litere și cifre, lungime precizată

## `foreach`. Clase de colecții. Sortarea folosind colecția `ArrayList`

1. Iterarea unui tablou unidimensional
2. Iterarea unui tablou bidimensional

 - `Rank`
 - `GetLength(0)`
 - `Length`


3. Iterarea unei colecții. Agendă telefonică. `Hashtable`

4. Sortarea folosind `ArrayList`

## Lucrul cu fișiere

1. Citirea liniilor dintr-un fișier text, le salvează într-o colecție, afișare în ordine inversă. (`Stack`)

2. Fișier:

```
Nume,Număr de telefon
```

`,` - delimitator

Să se creeze un alt fișier cu aceste date scrise în ordine alfabetică și formatate uniform trecând la începutul fișierului și data și ora curentă.

3. Se dă un fișier text de forma:

```
Nume Prenume NumărNote Nota1 Nota2 ... NotaN
```

Cu excepția primei linii care conține numărul de persoane
Să se afișeze într-un fișier de ieșire lista alfabetică a persoanelor împrună cu media fiecăreia împreună cu media generală.
