# Anagram
Denne console app finner anagrammer blant ordene som finnes i en liste, denne liste hentes fra en text-fil (angitt som første argumenten) med et ord per linje.
Programmen finner alle anagrammer for ordene i listen og lagrer resultaten i en valgfritt fil (angitt som andre argumenter) hvor hver linje inneholde ordene som er anagrammer av hverandre.

> AnagramConsole krever to argumenter, *arg1* referer txt fil med ordbok *arg2* angir txt fil hvor resultat skal lagres
- se under Deploy and run avsnitt for eksempler til bruk av AnagramConsole

## Code structure
    .
    ├── AnagramConsole          - Console application (C#) 
    ├── AnagramService          - Class library (C#)
    ├── AnagramService.Tests    - xUnit test of AnagramService (C#) 
## Deploy and run

  Last ned kildekoden fra siste verifisert release fra 'https://github.com/ferunic/Anagram/releases'
  
  Pakke ut og deploy fra din favorite IDE (VSCode, Visual Studio, Rider...)
  
  Kjør AnagramConsole.exe fra command line
  
  >Example
  -  .\AnagramConsole.exe C:\Anagram-ordbok.txt resultat.txt
  
  
