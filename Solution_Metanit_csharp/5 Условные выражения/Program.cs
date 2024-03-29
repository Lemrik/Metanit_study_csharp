﻿//Отдельный набор операций представляет условные выражения. Такие операции возвращают логическое значение, то есть значение типа bool: true, если выражение истинно, и false, если выражение ложно. К подобным операциям относятся операции сравнения и логические операции.

// ==

// Сравнивает два операнда на равенство. Если они равны, то операция возвращает true, если не равны, то возвращается false

int a = 10;
int b = 4;
bool c = a == b; // false


// !=

// Сравнивает два операнда и возвращает true, если операнды не равны, и false, если они равны.

int a1 = 10;
int b1 = 4;
bool c1 = a1 != b1;    // true
bool d1 = a1 != 10;     // false


// < 

// Операция "меньше чем". Возвращает true, если первый операнд меньше второго, и false, если первый операнд больше второго:

int a2 = 10;
int b2 = 4;
bool c2 = a2 < b2; // false


// >

// Операция "больше чем". Сравнивает два операнда и возвращает true, если первый операнд больше второго, иначе возвращает false

int a3 = 10;
int b3 = 4;
bool c3 = a3 > b3;     // true
bool d3 = a3 > 25;    // false


// <=

// Операция "больше или равно". Сравнивает два операнда и возвращает true, если первый операнд больше или равен второму, иначе возвращается false

int a4 = 10;
int b4 = 4;
bool c4 = a4 >= b4;     // true
bool d4 = a4 >= 25;    // false