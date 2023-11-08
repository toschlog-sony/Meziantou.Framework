﻿namespace Meziantou.Framework.Diagnostics.ContextSnapshot;

public sealed class SpecialFolderSnapshot
{
    public string AdminTools { get; } = Environment.GetFolderPath(Environment.SpecialFolder.AdminTools);
    public string ApplicationData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    public string CDBurning { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CDBurning);
    public string CommonAdminTools { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools);
    public string CommonApplicationData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
    public string CommonDesktopDirectory { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
    public string CommonDocuments { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
    public string CommonMusic { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic);
    public string CommonOemLinks { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonOemLinks);
    public string CommonPictures { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures);
    public string CommonProgramFiles { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles);
    public string CommonProgramFilesX86 { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86);
    public string CommonPrograms { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);
    public string CommonStartMenu { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
    public string CommonStartup { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup);
    public string CommonTemplates { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates);
    public string CommonVideos { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos);
    public string Cookies { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
    public string Desktop { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    public string DesktopDirectory { get; } = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
    public string Favorites { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Favorites);
    public string Fonts { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
    public string History { get; } = Environment.GetFolderPath(Environment.SpecialFolder.History);
    public string InternetCache { get; } = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
    public string LocalApplicationData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
    public string LocalizedResources { get; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalizedResources);
    public string MyComputer { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
    public string MyDocuments { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    public string MyMusic { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
    public string MyPictures { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
    public string MyVideos { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
    public string NetworkShortcuts { get; } = Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts);
    public string Personal { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
    public string PrinterShortcuts { get; } = Environment.GetFolderPath(Environment.SpecialFolder.PrinterShortcuts);
    public string ProgramFiles { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
    public string ProgramFilesX86 { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
    public string Programs { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
    public string Recent { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
    public string Resources { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Resources);
    public string SendTo { get; } = Environment.GetFolderPath(Environment.SpecialFolder.SendTo);
    public string StartMenu { get; } = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
    public string Startup { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
    public string System { get; } = Environment.GetFolderPath(Environment.SpecialFolder.System);
    public string SystemX86 { get; } = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
    public string Templates { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Templates);
    public string UserProfile { get; } = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
    public string Windows { get; } = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
}