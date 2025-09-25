module Projects

open System.IO
open Semver
open Fake.IO
open Spec

type NpmPackage =
    | Versioned of name: string * version: SemVersion
    | Basic of name: string
type FsProjPath = FsProjPath of string

module FsProjPath =
    let value = function FsProjPath value -> value
    let create = FsProjPath
module NpmPackage =
    let create = Basic
    let getName = function Basic value | Versioned(value,_) -> value
    module Versioned =
        let create (major: int) (minor: int) (patch: int) name =
            (name, SemVersion(major,minor,patch))
            |> Versioned
    let toVersioned major minor patch = getName
                                        >> Versioned.create major minor patch

type Project = {
    Path: FsProjPath
    Name: string 
    NpmPackage: NpmPackage voption
}

type ProjectBuilder() =
    member inline _.Yield(_: unit) = ()
    [<CustomOperation>]
    member inline _.path(_: unit, value: string) =
        {
            Path =
                FsProjPath.create value
            Name =
                // default name to file name
                value
                |> Path.GetFileNameWithoutExtension
            NpmPackage = ValueNone
        }
    [<CustomOperation>]
    member inline _.path(state: Project, value: string) =
        { state with Path = FsProjPath.create value }
    [<CustomOperation>]
    member inline _.name(state: Project, value: string) =
        { state with Name = value }
    [<CustomOperation>]
    member inline _.npm(state: Project, value: string) =
        { state with NpmPackage = NpmPackage.create value |> ValueSome }
    [<CustomOperation>]
    member inline _.npm(state: Project, value: string, major, ?minor, ?patch) =
        let minor = defaultArg minor 0
        let patch = defaultArg patch 0
        { state with NpmPackage = ValueSome <| NpmPackage.Versioned.create major minor patch value }
    member inline _.Run(state: Project) = state
let project = ProjectBuilder()

module IgnoredProjects =
    let private ignore (path: string) = Path.GetFileNameWithoutExtension(path)
    let chartJs = ignore Files.Root.``Partas.Solid.ChartJs``.``Partas.Solid.ChartJs.fsproj``
    let dnd = ignore Files.Root.``Partas.Solid.Dnd``.``Partas.Solid.Dnd.fsproj``
    let dndkit = ignore Files.Root.``Partas.Solid.DndKit``.``Partas.Solid.DndKit.fsproj``
    let embla = ignore Files.Root.``Partas.Solid.EmblaCarousel``.``Partas.Solid.EmblaCarousel.fsproj``
    let tanstackVirtual = ignore Files.Root.``Partas.Solid.TanStack.Virtual``.``Partas.Solid.TanStack.Virtual.fsproj``
    let bindings = ignore Files.Root.``Partas.Solid.Bindings``.``Partas.Solid.Bindings.fsproj``
    
module Projects =
    let zagJs = project {
        path Files.Root.``Glutinum.ZagJs``.``Glutinum.ZagJs.fsproj``
    }
    let internationalised = project {
        path Files.Root.``Glutinum.Internationalised``.``Glutinum.Internationalised.fsproj``
    }
    let apexCharts = project {
        path Files.Root.``Partas.Solid.ApexCharts``.``Partas.Solid.ApexCharts.fsproj``
        npm "solid-apexcharts" 0 4 0
    }
    let arkUi = project {
        path Files.Root.``Partas.Solid.ArkUI``.``Partas.Solid.ArkUI.fsproj``
        npm "@ark-ui/solid" 5 0 0
    }
    let cmdk = project {
        path Files.Root.``Partas.Solid.Cmdk``.``Partas.Solid.Cmdk.fsproj``
        npm "cmdk-solid" 1 1 0
    }
    let corvu = project {
        path Files.Root.``Partas.Solid.Corvu``.``Partas.Solid.Corvu.fsproj``
        npm "@corvu/otp-field" 0 1 4
    }
    let cva = project {
        path Files.Root.``Partas.Solid.Cva``.``Partas.Solid.Cva.fsproj``
        npm "class-variance-authority" 0 7 1
    }
    let kobalte = project {
        path Files.Root.``Partas.Solid.Kobalte``.``Partas.Solid.Kobalte.fsproj``
        npm "@kobalte/core" 0 13 10
    }
    let lucide = project {
        path Files.Root.``Partas.Solid.Lucide``.``Partas.Solid.Lucide.fsproj``
        npm "lucide-solid" 0 513 0
    }
    let modularForms = project {
        path Files.Root.``Partas.Solid.ModularForms``.``Partas.Solid.ModularForms.fsproj``
        npm "@modular-forms/solid" 0 29 1
    }
    let motion = project {
        path Files.Root.``Partas.Solid.Motion``.``Partas.Solid.Motion.fsproj``
        npm "solid-motionone" 1 0 0
    }
    let neodrag = project {
        path Files.Root.``Partas.Solid.NeoDrag``.``Partas.Solid.NeoDrag.fsproj``
        npm "@neodrag/solid" 2 3 0
    }
    let sonner = project {
        path Files.Root.``Partas.Solid.Sonner``.``Partas.Solid.Sonner.fsproj``
        npm "solid-sonner" 0 2 8
    }
    let storybook = project {
        path Files.Root.``Partas.Solid.Storybook``.``Partas.Solid.Storybook.fsproj``
    }
    let tanstackTables = project {
        path Files.Root.``Partas.Solid.TanStack.Table``.``Partas.Solid.TanStack.Table.fsproj``
        npm "@tanstack/solid-table" 8 0 0
    }
    let zag = project {
        path Files.Root.``Partas.Solid.Zag``.``Partas.Solid.Zag.fsproj``
    }
    
    
let projects = [
    Projects.zagJs
    Projects.internationalised
    Projects.apexCharts
    Projects.arkUi
    Projects.cmdk
    Projects.corvu
    Projects.cva
    Projects.kobalte
    Projects.lucide
    Projects.modularForms
    Projects.motion
    Projects.neodrag
    Projects.sonner
    // TODO - fix storybook errors
    // Projects.storybook
    Projects.tanstackTables
    Projects.zag
]    
let ignored = [
    IgnoredProjects.chartJs
    IgnoredProjects.dnd
    IgnoredProjects.dndkit
    IgnoredProjects.embla
    IgnoredProjects.tanstackVirtual
    IgnoredProjects.bindings
]
