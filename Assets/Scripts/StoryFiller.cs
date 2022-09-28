using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/********************************************/
/******************** Classe que conte la batalla ***************/
/******** Creem un seguit de nodes amb la frase que diu el joc **/
/****** i les possibles respostes que pot escollir l'usuari *****/
/**************** Com l'estructura de nodes   *******************/
public static class StoryFiller
{
    public static StoryNode FillStory()
    {
        // creen els nodes
        var root = CreateNode(
            "Al garrotín, al garrotan, vera vera vera vera de San Juan.",
            new[] {
            "Encara que tu me posis tres olives en un plat.",
            "Aire, aire, aire, la festa major d\'Alguaire.",
            "Al garrotín, al garrotan, vera vera vera vera de San Juan."});

        var node1 = CreateNode(
            "A tu ja no et vull per dona perquè tens el cul cagat. ",
            new[] {
            "I vaig ser l\'amic del bufa,que se\'n va fotre una llufa, de la pudor que va fer, la va dinyar un carabiner.",
            "Si el Rafalito, alcalde i el Sicus fos manescal, a l'Ajuntament de Lleida, no hi hauria mai un ral.",
            "Al garrotín, al garrotan, vera vera vera vera de San Juan."});

        var node2 = CreateNode(
            "Aire, aire, aire, la festa major d'Alguaire." ,
            new[] {
            "I també la de Serós que les noies d'aquest poble totes tenen el cul gros.",
            "Al garrotín, al garrotan, vera vera vera vera de San Juan.",
            "Una senyorita muy entusiasmada aixeca la cama i le juno la ensïimada."});

        var node3 = CreateNode(
           "Allà mossèn Paguera, a dalt d'una figuera, d'una llufa que es va fer, va matar un carabiner. " ,
           new[] {
            "Al garrotín, al garrotan, vera vera vera vera de San Juan.", 
            "I li fot un cop a l'ull, i de l'ull a la costella, de la costella a budell colat, perquè mai més pugui ginyar.",
            "Li foto cop de puny a l'ull i d'un ull a la costella, li vaig rebentar l'orella de l'orella al budell culat per a que mai més pogués ginyar."});

        var node4 = CreateNode(
           "Entre pet i pet i pet, entre pet i pet i ril, els gitanos de la costa, fan fora la Guàrdia Cívil." ,
           new[] {
            "Baixant el carrer Major, vaig trobar una planxadora, que pagant-li dos ralets es deixava tocar la xona.",
           "Al garrotín, al garrotan, vera vera vera vera de San Juan.",
           "Coneixereu a mossèn Miquel que fot llarga la..., la fot llarga com el braç que amb la punta la car regava tot Soleràs."});

        var node5 = CreateNode(
           "Qué es aquello que reluce, en la falda del castillo, em sembla que el ninot del Josep el Baratillo. ",
           new[] {
            "Al garrotín, al garrotan, vera vera vera vera de San Juan."});

        var node6 = CreateNode(
            "Ara ve la de Seròs, que les paies d\'aquest poble, totes foten el cul gros.",
            new[] {
             "I vaig ser l\'amic del bufa,que se\'n va fotre una llufa, de la pudor que va fer, la va dinyar un carabiner.",
            "Si el Rafalito, alcalde i el Sicus fos manescal, a l'Ajuntament de Lleida, no hi hauria mai un ral.",
            "Al garrotín, al garrotan, vera vera vera vera de San Juan."});

        var node7 = CreateNode(
            "Els peixos del riu de Lleida diuen que són de mal pair, los calistros del Pla de l'Aigua se'ls jalen sense fregir.",
            new[] {
            "Al garrotín, al garrotan, vera vera vera vera de San Juan.",
            "I també la de Serós que les noies d'aquest poble totes tenen el cul gros.",
            "Una senyorita muy entusiasmada aixeca la cama i le juno la ensïimada."});

        var node8 = CreateNode(
           "Una planxadora hi havia al carrer Major, que per dos pessetetes se deixava tocar el fricandó. ",
           new[] {
            "Li foto cop de puny a l'ull i d'un ull a la costella, li vaig rebentar l'orella de l'orella al budell culat per a que mai més pogués ginyar.",
               "Al garrotín, al garrotan, vera vera vera vera de San Juan.",
            "I li fot un cop a l'ull, i de l'ull a la costella, de la costella a budell colat, perquè mai més pugui ginyar."});

        var node9 = CreateNode(
           "Si el Calsoné fos alcalde i el gran Marqués concejal a l'Ajuntament de Lleida no n'hi hauria mai un ral.",
           new[] {
            "Baixant el carrer Major, vaig trobar una planxadora, que pagant-li dos ralets es deixava tocar la xona.",
            "Coneixereu a mossèn Miquel que fot llarga la..., la fot llarga com el braç que amb la punta la car regava tot Soleràs.",
           "Al garrotín, al garrotan, vera vera vera vera de San Juan."});

        var node10 = CreateNode(
           "Al garrotín, al garrotán, a la vera, vera, vera de Sant Joan, al garrotín, al garrotán, a la vera, vera, vera de Sant Joan. ",
           new[] {
            "Al garrotín, al garrotan, vera vera vera vera de San Juan."});

        // es conectea cada resposta (index) amb el node que hi ha la replica 
        root.NextNode[0] = node1;
        root.NextNode[1] = node6;
        root.NextNode[2] = root;

        node1.NextNode[0] = node6;
        node1.NextNode[1] = node2;
        node1.NextNode[2] = root;

        node2.NextNode[0] = node3;
        node2.NextNode[1] = root;
        node2.NextNode[2] = node6;

        node3.NextNode[0] = root;
        node3.NextNode[1] = node4;
        node3.NextNode[2] = node6;

        node4.NextNode[0] = node5;
        node4.NextNode[1] = root;
        node4.NextNode[2] = node6;
        //possible fi de la batalla 
        node5.IsFinal = true; 
           
        node6.NextNode[0] = node7;
        node6.NextNode[1] = node1;
        node6.NextNode[2] = root;

        node7.NextNode[0] = root;
        node7.NextNode[1] = node1;
        node7.NextNode[2] = node8;

        node8.NextNode[0] = node9;
        node8.NextNode[1] = root;
        node8.NextNode[2] = node1;

        node9.NextNode[0] = node1;
        node9.NextNode[1] = node10;
        node9.NextNode[2] = root;

        //possible fi de la batalla 
        node10.IsFinal = true;
        return root;
    }

    // funcio que incialitza els nodes amb el text del joc i les repliques del jugador. 
    private static StoryNode CreateNode(string history, string[] options)
    {
        var node = new StoryNode
        {
            History = history,
            Answers = options,
            NextNode = new StoryNode[options.Length]
        };
        return node;
    }

}

