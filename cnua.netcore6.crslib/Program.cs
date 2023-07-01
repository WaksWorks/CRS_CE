/** 
 * Copyright 2023 (C) WaksWorks™ - All Rights Reserved
 * info@waksworks.co.uk
 * 
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Wakeelu Mamudu wmamudu@aieo.co.uk, 2023-05-17
 */
using System.CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using CSR.Entities.Extensions;
using CSR.Collections;
using System.IO;

internal class Program
{
    private static async Task<int> Main(string[] args)
    {
        Option<FileInfo> fileOption = new Option<FileInfo>(name: "--file",
            description: @"The WhatsApp Chat Export file to read and transform \n" +
            "into Chatroom Studio assets\n" +
            ".csv, .wav, .txt");
        RootCommand rootCommand = new RootCommand("Write transcripts");
        rootCommand.AddAlias(@"-f");
        rootCommand.AddOption(fileOption);

        rootCommand.SetHandler((file) =>
        {
            WriteCSV(file);
        },
            fileOption);

        return await rootCommand.InvokeAsync(args);
    }
    internal static void WriteCSV(FileInfo fi)
    {
        Console.WriteLine("Writing  Files");
        PostList pl = new PostList(fi.FullName);
        pl.SaveOriginalText();
        pl.LoadOriginalText();
        pl.SaveCSV();
        pl.SaveJson();
        pl.WriteAudioPosts();
        pl.WriteAudioTranscription();

        Console.WriteLine(pl.GetFilePath() + " File Written");
    }
}