﻿namespace Library.Host;

public class Buch
{
    private readonly string titel;
    private readonly string autor;
    private readonly DateTime veroeffentlichungsdatum;

    public Buch(string titel, string autor, DateTime veroeffentlichungsdatum)
    {
        this.titel = titel;
        this.autor = autor;
        this.veroeffentlichungsdatum = veroeffentlichungsdatum;
    }

    public override string ToString()
    {
        return $"Titel: {titel} - {autor}, veröffentlicht am: {veroeffentlichungsdatum:dd.MM.yyyy}";
    }
}