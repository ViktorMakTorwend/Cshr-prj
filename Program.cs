// for(byte i = 0; i < 10; i++) {
//     Console.WriteLine("Element: {0}", i);
// }

// byte k = 0;
// while(k < 10) {
//    Console.WriteLine("Element: {0}", k);
//    k++;
// }

// bool isHasCar = true;
// while(isHasCar) {
//     Console.WriteLine("Input the word");
//     string end = Console.ReadLine();
//     if(end =="end") {
//         isHasCar = false;
//     }
// }

for (short i = 0; i < 10; i++) {
    // if (i > 5) {
    //     break;
    // }
    if(i % 2 == 0) {
        continue;
    }
    Console.WriteLine("Element: {0}", i);
}