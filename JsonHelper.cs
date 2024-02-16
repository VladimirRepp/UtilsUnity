using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Расширяет JsonUtility для работы с массивами
/// </summary>
public static class JsonHelper
{
    /// <summary>
    /// Получить массив из JSON строки
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="json"></param>
    /// <returns></returns>
    public static T[] FromJson<T>(string json)
    {
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
        return wrapper.Items;
    }

    /// <summary>
    /// Получить JSON строку из массива
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string ToJson<T>(T[] array)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper);
    }

    /// <summary>
    /// Получить JSON строку из массива
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="array"></param>
    /// <param name="prettyPrint"></param>
    /// <returns></returns>
    public static string ToJson<T>(T[] array, bool prettyPrint)
    {
        Wrapper<T> wrapper = new Wrapper<T>();
        wrapper.Items = array;
        return JsonUtility.ToJson(wrapper, prettyPrint);
    }

    /// <summary>
    /// Сериализуемая обёртка 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    private class Wrapper<T>
    {
        public T[] Items;
    }
}

/*
    Пример:
    
    - Convert to JSON
    Player[] playerInstance = new Player[2];
    string playerToJson = JsonHelper.ToJson(playerInstance, true);

    - Convert from JSON
    string jsonString = "{\r\n    \"Items\": [\r\n        {\r\n            \"playerId\": \"8484239823\",\r\n            \"playerLoc\": \"Powai\",\r\n            \"playerNick\": \"Random Nick\"\r\n        },\r\n        {\r\n            \"playerId\": \"512343283\",\r\n            \"playerLoc\": \"User2\",\r\n            \"playerNick\": \"Rand Nick 2\"\r\n        }\r\n    ]\r\n}";
    Player[] player = JsonHelper.FromJson<Player>(jsonString);
*/
