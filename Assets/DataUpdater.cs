using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DataUpdater
{
    [SerializeField]
    private static string googleSheetDocid = "1UBlUaB16RXbNz8w0wuFkPVLR22kY28QJY7sNJXfrotA";
    [SerializeField]
    private static string spreadsheetNumber = "0";
   
    [MenuItem("Load Data/Load Unit Data",false,1)]
    public static List<Dictionary<string,object>> LoadSample()
    {
        List<Dictionary<string,object>> result=null;
        string csvData = "";

        if (CSVDownloader.DownloadData(googleSheetDocid, spreadsheetNumber,out csvData))
        {
            Debug.Log(csvData);
        }

        return result;
    }

}
