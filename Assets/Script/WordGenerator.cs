using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordlist = { 
    "cat", "dog", "sun", "hat", "run", "pen", "bat", "cup", "red", "box",
    "fish", "milk", "book", "rain", "sand", "tree", "jump", "blue", "shoe", "snow",
    "apple", "broom", "cloud", "green", "house", "chair", "horse", "light", "river", "table",
    "banana", "orange", "castle", "window", "yellow", "garden", "pencil", "button", "mountain", "rocket",
    "chicken", "elephant", "keyboard", "umbrella", "vegetable", "airplane", "computer", "dinosaur", "firework", "hamburger",
    "activity", "balloon", "birthday", "diamond", "elephant", "football", "giraffe", "helicopter", "internet", "jellyfish",
    "knowledge", "language", "magazine", "newspaper", "opinion", "question", "resource", "situation", "telescope", "universe",
    "volunteer", "whisper", "xylophone", "yesterday", "zebra", "analyze", "benefit", "category", "decision", "electricity",
    "freedom", "guidance", "holiday", "independent", "journalist", "knowledgeable", "leadership", "measurement", "necessary", "organization",
    "partnership", "qualification", "recognition", "specialist", "technology", "unavailable", "validation", "wonderful", "xenophobia", "youthful",
    "abandonment", "beneficial", "characteristic", "determination", "efficiency", "friendship", "government", "hypothesis", "imagination", "jealousy",
    "kilometer", "laboratory", "management", "notification", "opportunity", "perspective", "qualification", "responsibility", "satisfaction", "transportation",
    "understanding", "verification", "workmanship", "xenophobic", "yesterday", "zoology", "achievement", "behavior", "commitment", "development",
    "environment", "foundation", "geography", "happiness", "inspiration", "justification", "knowledgeable", "leadership", "motivation", "negotiation",
    "optimization", "performance", "questionnaire", "regulation", "speculation", "technology", "understanding", "visualization", "workstation", "xerox",
    "youthful", "zoological", "anticipation", "biodiversity", "collaboration", "documentation", "experience", "fundamental", "globalization", "harmony",
    "implementation", "justifiable", "knowledgeable", "legislation", "modernization", "notification", "organization", "practicality", "qualification", "representation"
};

    public static string RandomWord()
    {
        int rand_idx = Random.Range(0 , wordlist.Length);
        string randomWord = wordlist[rand_idx];

        return randomWord;
    }
}
