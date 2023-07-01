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
internal class Program_old
{
    private static async Task<int> Main(string[] args)
    {
        Option<FileInfo> fileOption = new Option<FileInfo>( name: "--file",
            description: @"The WhatsApp Chat Export file to read and transform \n" +
            "into Chatroom Studio assets\n" +
            ".csv, .wav, .waksx, .crsbx, .obdx");
        RootCommand rootCommand = new RootCommand("Write Chatroom Studio FS Assets");
        rootCommand.AddAlias(@"-f");
        rootCommand.AddOption(fileOption);

        rootCommand.SetHandler((file) =>
        {
			WriteCSV(file);
        },
            fileOption);
    
        return await rootCommand.InvokeAsync(args);
    }

    private static void WriteCSV(object file)
    {
        throw new NotImplementedException();
    }
}