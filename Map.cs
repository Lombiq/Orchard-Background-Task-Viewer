﻿using System;
using Piedone.BackgroundTaskViewer.Controllers;
using Piedone.BackgroundTaskViewer.Drivers;
using Piedone.BackgroundTaskViewer.Filters;
using Piedone.BackgroundTaskViewer.Handlers;
using Piedone.BackgroundTaskViewer.Models;
using Piedone.BackgroundTaskViewer.Services;

/* 
 * In this file, you'll find the index of the whole (or at least most of the) module's classes for easier navigation between topics.
 * You can navigate directly to classes and their methods by clicking on their names (enclosed in a Factory<T>() ) and pressing F12.
 * 
 * This class is not doing anything and only serves as an easy to use table of contents.
 */
namespace Piedone.BackgroundTaskViewer
{
    static class Map
    {
        private static T Factory<T>() { return default(T); }

        private static void Treasure()
        {
            // Module.txt: features and dependencies


            // Static resources: styles and scripts
                // Declaration
                Factory<ResourceManifest>();

                // Usage: require/include
                // Views/PersonListDashboard


            // [Themed]: Integrating with the current theme
            Factory<YourFirstOrchardController>()
                .Index();


            // Dependency injection and basic services
                // Dependency injection and types of dependencies, Logger, Localizer, Notifier
                Factory<DependencyInjectionController>();

                // WorkContext and OrchardServices
                // Views/PersonListDashboard.cshtml
                Factory<ContentsAdminController>();

                // Ways of injections
                    // Single
                    Factory<DependencyInjectionController>();

                    // IEnumberable<T>
                    Factory<PersonManager>();

                    // Work<T> and Lazy<T>
                    Factory<PersonListPartHandler>();


            // Data storage
                // Record
                Factory<PersonRecord>();

                // Repository
                Factory<PersonManager>().SavePerson("", Sex.Female, DateTime.Now, "");

                // Record migrations
                Factory<Migrations>();

                // ContentManager
                Factory<ContentsAdminController>().LatestPersonLists();

                // Abstracted file storage with IStorageProvider
                Factory<FileManagementController>();


            // Exception handling
                // OrchardException
                Factory<FileManagementController>().Create();

                // IsFatal()
                Factory<PersonController>().CreateBadPerson();


            // Ad-hoc shape creation: Views/PersonListDashboard.cshtml


            // OrchardFeature attribute
            Factory<PersonListPart>();


            // ContentPart development
                // ContentPart, ContentPartRecord
                Factory<PersonListPart>(); // LazyField<T>
                Factory<PersonListPartRecord>();

                // ContentType migrations
                Factory<ContentsMigrations>().Create();

                // Drivers: shapes, display and edit methods, export/import
                Factory<PersonListPartDriver>();
                Factory<ContentsAdminController>().LatestPersonLists();

                // Handlers and filters
                Factory<PersonListPartHandler>();

                // Placement.info


            // ContentField development, very similiar to ContentPart development
                // ContentField
                Factory<YouTubeEmbedField>();

                // Attaching a field to a part
                Factory<ContentsMigrations>().UpdateFrom1();

                // Driver for the field
                Factory<YouTubeEmbedFieldDriver>();


            // Custom routes
            Factory<Routes>();


            // Navigation providers: implementing an admin menu (with corresponding admin controller)
            Factory<AdminMenu>();
            Factory<ContentsAdminController>();


            // Filters: result and action filters, FilterProvider
            Factory<ResourceFilter>();


            // Event bus and event handlers
            Factory<BackgroundTask>();
            Factory<ScheduledTask>();
            Factory<DynamicEventHandler>();


            // Permissions and authorization
            Factory<Permissions>();
            Factory<ContentsAdminController>().PersonListDashboard();


            // Background and scheduled tasks
            Factory<BackgroundTask>();
            Factory<ScheduledTask>();


            // Caching: ICacheManager and ICacheService, ISignals
            Factory<DateTimeCachingService>();
            Factory<CacheController>();


            // Unit tests
                // IClock
                Factory<DateTimeCachingService>();

                /* Check out the OrchardHUN.TrainingDemo.Tests folder in the project folder of this module for a complete
                 * unit test, starting with StartHere.txt
                 */
        }
    }
}