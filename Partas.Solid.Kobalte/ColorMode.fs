namespace Partas.Solid.Kobalte

open Fable.Core
open Partas.Solid

// [<AutoOpen; Erase>]
// module ColorMode =
//     /// <summary>
//     /// Primitive that reads from <c>ColorModeProvider</c> context,
//     /// Returns the color mode and function to toggle it.
//     /// </summary>
//     [<Import("useColorMode", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let useColorMode () : ColorModeContextType = nativeOnly
//     /// <summary>
//     /// Change value based on color mode.
//     /// </summary>
//     /// <example>
//     /// <code lang="js">
//     /// const Icon = useColorModeValue(MoonIcon, SunIcon)
//     /// </code>
//     /// </example>
//     /// <param name="light">
//     /// the light mode value
//     /// </param>
//     /// <param name="dark">
//     /// the dark mode value
//     /// </param>
//     /// <returns>
//     /// A memoized value based on the color mode.
//     /// </returns>
//     [<Import("useColorModeValue", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let useColorModeValue<'TLight, 'TDark> (light: 'TLight, dark: 'TDark) : solid_js.Accessor<U2<'TLight, 'TDark>> = nativeOnly
//     /// <summary>
//     /// Provides context for the color mode based on config in <c>theme</c>
//     /// Returns the color mode and function to toggle the color mode
//     /// </summary>
//     [<Import("ColorModeProvider", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let ColorModeProvider (props: ColorModeProviderProps) : solid_js.JSX.Element = nativeOnly
//     [<Import("ColorModeScript", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let ColorModeScript (props: ColorModeScriptProps) : solid_js.JSX.Element = nativeOnly
//     [<Import("createLocalStorageManager", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let createLocalStorageManager (key: string) : ColorModeStorageManager = nativeOnly
//     [<Import("createCookieStorageManager", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let createCookieStorageManager (key: string, ?cookie: string) : ColorModeStorageManager = nativeOnly
//     [<Import("cookieStorageManagerSSR", "REPLACE_ME_WITH_MODULE_NAME")>]
//     let cookieStorageManagerSSR (cookie: string) : ColorModeStorageManager = nativeOnly
//
//
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type ColorMode =
//     | light
//     | dark
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type ConfigColorMode =
//     | light
//     | dark
//     | system
//
// [<RequireQualifiedAccess>]
// [<StringEnum(CaseRules.None)>]
// type MaybeConfigColorMode =
//     | light
//     | dark
//     | system
//
// [<AllowNullLiteral>]
// [<Interface>]
// type ColorModeStorageManager =
//     /// <summary>
//     /// The type of storage.
//     /// </summary>
//     abstract member ``type``: ColorModeStorageManager.``type`` with get, set
//     /// <summary>
//     /// Whether it's an SSR environment.
//     /// </summary>
//     abstract member ssr: bool option with get, set
//     /// <summary>
//     /// Get the color mode from the storage.
//     /// </summary>
//     abstract member get: (ConfigColorMode option -> MaybeConfigColorMode) with get, set
//     /// <summary>
//     /// Save the color mode in the storage.
//     /// </summary>
//     abstract member set: (ConfigColorMode -> unit) with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type ColorModeContextType =
//     abstract member colorMode: Accessor<ColorMode> with get, set
//     abstract member setColorMode: (ConfigColorMode -> unit) with get, set
//     abstract member toggleColorMode: (unit -> unit) with get, set
//
// [<AllowNullLiteral>]
// [<Interface>]
// type ColorModeOptions =
//     /// <summary>
//     /// The initial color mode to use.
//     /// </summary>
//     abstract member initialColorMode: ConfigColorMode option with get, set
//     /// <summary>
//     /// Whether css transitions should be disabled during the color mode changes.
//     /// </summary>
//     abstract member disableTransitionOnChange: bool option with get, set
//     /// <summary>
//     /// The color mode storage manager, either localStorage or cookie.
//     /// </summary>
//     abstract member storageManager: ColorModeStorageManager option with get, set
//
// type ColorModeProviderProps =
//     ParentProps<ColorModeOptions>
//
// [<AllowNullLiteral>]
// [<Interface>]
// type ColorModeScriptProps =
//     /// <summary>
//     /// The initial color mode to use.
//     /// </summary>
//     abstract member initialColorMode: ConfigColorMode option with get, set
//     /// <summary>
//     /// The type of the color mode storage manager, either localStorage or cookie.
//     /// </summary>
//     abstract member storageType: ColorModeScriptProps.storageType option with get, set
//     /// <summary>
//     /// The key used to store color mode preference in localStorage or cookie.
//     /// </summary>
//     abstract member storageKey: string option with get, set
//     abstract member nonce: string option with get, set
//
//
//
//
//
//
// module ColorModeStorageManager =
//
//     [<RequireQualifiedAccess>]
//     [<StringEnum(CaseRules.None)>]
//     type ``type`` =
//         | cookie
//         | localStorage
//
// module ColorModeScriptProps =
//
//     [<RequireQualifiedAccess>]
//     [<StringEnum(CaseRules.None)>]
//     type storageType =
//         | localStorage
//         | cookie
