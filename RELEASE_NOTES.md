# RELEASE NOTES

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to a flavored version of [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

<details>
<summary>See the spec for this SemVer flavor.</summary>
<h3>Epoch Scoped Semver</h3>
This flavor adds an optional marketable value called an `EPOCH`.
There is also an optional disambiguating `SCOPE` identifier for delineating tags for packages in a mono repo.

<blockquote>The motivation for this is to prevent resistance to utilising SemVer major bumps
correctly, by allowing a separate marketable identifier which is easily compatible
with the current SemVer spec.</blockquote>
An Epoch/Scope (**Sepoch**) is an OPTIONAL prefix to a typical SemVer.

* A Sepoch MUST BE bounded by `_` underscores `_`.

* The identifiers MUST BE ALPHABETICAL (A-Za-z) identifiers.

* The Epoch SHOULD BE upper case

* The Epoch MUST come before the Scope, if both are present.

* The Scope MUST additionally be bounded by `(` parenthesis `)`.

* The Scope SHOULD BE capitalised/pascal cased.

* A Sepoch CAN BE separated from SemVer by a single white space where this is allowed (ie not allowed in git tags).

* Epoch DOES NOT influence precedence.

* Scope MUST uniquely identify a single components versioning.

* Different scopes CANNOT BE compared for precedence.

* A SemVer without a Scope CAN BE compared to a Scoped SemVer for compatibility. But caution is advised.

> There is no enforcement for ordering EPOCHs in this spec, as it
would be overly restrictive and yield little value since we can delineate and
earlier EPOCH from a later EPOCH by the SemVers.
> 

**Examples:**

```mermaid
gitGraph
commit tag: "_ALPS_1.2.3"
branch develop
commit id: "add: ..."
commit
checkout main
cherry-pick id: "add: ..." tag: "_ALPS_2.1.3"
checkout develop
commit
commit
checkout main
merge develop tag: "_ALPS_3.4.5"
checkout develop
commit
commit
checkout main
merge develop tag: "_BRAVO_4.0.0" type: HIGHLIGHT

```

**While there are breaking changes between versions 1 to 3, we expect that it is less than
from 3 to 4. We expect the API surface would change more dramatically, or there is some other significant
milestone improvement, in the change from version 3 epoch ALPS to version 4 epoch BRAVO.**

```
_WILDLANDS(Core)_ 4.2.0
_WILDLANDS(Engine)_ 0.5.3
_DELTA(Core)_ 5.0.0
_DELTA(Engine)_ 0.5.3

```

**Cannot be compared to `Core` versions. Both Engine versions are equal, we can identify that
the ecosystems marketed change does not change the Engine packages API**

</details>
<details>
<summary>Quick navigation</summary>
<h3>Scopes:</h3>
<ul>
<li><a href="#apexcharts">ApexCharts</a></li>
<li><a href="#arkui">ArkUI</a></li>
<li><a href="#build">Build</a></li>
<li><a href="#cmdk">Cmdk</a></li>
<li><a href="#corvu">Corvu</a></li>
<li><a href="#cva">Cva</a></li>
<li><a href="#internationalised">Internationalised</a></li>
<li><a href="#kobalte">Kobalte</a></li>
<li><a href="#lucide">Lucide</a></li>
<li><a href="#modularforms">ModularForms</a></li>
<li><a href="#motion">Motion</a></li>
<li><a href="#neodrag">NeoDrag</a></li>
<li><a href="#sonner">Sonner</a></li>
<li><a href="#storybook">Storybook</a></li>
<li><a href="#table">Table</a></li>
<li><a href="#zagjs">ZagJs</a></li>
</ul>
</details>
-----------------------

# ApexCharts

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# ArkUI

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Build

## UNRELEASED

-----------------------

# Cmdk

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* Bump dependencies Add support for Polymorphism to Kobalte - cabboose@[6af9e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/6af9e173fad5b6ffc09341ba0a01689b7dc33220)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Corvu

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* Bump dependencies Add support for Polymorphism to Kobalte - cabboose@[6af9e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/6af9e173fad5b6ffc09341ba0a01689b7dc33220)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Cva

## [UNRELEASED](https://github.com/shayanhabibi/Partas.Solid.Bindings/compare/_%28Cva%29_0.1.0...HEAD)

-----------------------

# Internationalised

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Kobalte

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= 0.3.4 PATCH: Color utility import paths corrected as per https://github.com/kobaltedev/kobalte/issues/586 - cabboose@[69a07](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/69a071887a1441f0e81a1487c7a421c7d47c3a30)
  

* =KOBALTE= REFACTOR: Remove chance of ChildLambdaProvider and HtmlContainer conflict by preferencing ChildLambdaProvider except in cases where it is provided as a virtualiser interface. In this case, a type alias which provides the ChildLambdaProvider interface is provided with the Virtualiser suffix - cabboose@[f21f7](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f21f74f664028aa6a9866d012d40d0402a3934cf)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* =KOBALTE= VERSION: Kobalte 0.3.0 BREAKING: Combobox components typed where required. ChildLambdaInterfaces added where component accepts as a render method for children. ADDED: Context value added for combobox ADDED: Tooltip Context ADDED: ToggleGroupContext ADDED: ToggleButton ChildLambdaInterface ADDED: SelectionManager interface ADDED: Collection interface ADDED: Enum SelectionMode ADDED: Enum FileError ADDED: PaginationContext ADDED: image context ADDED: Hovercard context ADDED: Context Value added for FileField REFACTOR: Better typing of FileField. DOCUMENTATION: From source for ToggleGroup.fs DOCUMENTATION: Added docs for Pagination from source DOCUMENTATION: Documentation from source for hover card added DOCUMENTATION: Documentation for Collapsible from source - cabboose@[3b403](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b403af176de24584c4ae3f56149aa5a6e1f2d69)
  

* Patch BreadcrumbsLink property `currrent` to `current` - cabboose@[99ab9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/99ab9e8b5c1a768b97489f96d79e7c42525227e4)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Update `Value` interface to use `ChildLambdaProvider` instead of `KobalteStateProvider`. - cabboose@[59be7](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/59be7482da0499ec103abfb9750fa016745a77d5)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Add glutinum transformer for posterity - cabboose@[ffa45](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/ffa45135ad6ffe8530cc6d0e4a8f6526028f582e)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upd kobalte towards 1.0.0 spec - cabboose@[c19f8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/c19f89d93cd39dff120d0d97207f8ba4185ad2fb)
  

* update and refactor - cabboose@[b386b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b386bf957d5652d9d16c58767f5cab4ad1b49480)
  

* upd kobalte towards 1.0.0 spec - cabboose@[cc9a4](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/cc9a4589f7a0087e5ba519116c3098430ef07f32)
  

* Require Qualified access for Kobalte enum LoadingStatus (due to Error name collision) - cabboose@[ae035](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/ae035d93934578bb6a87964d2ed5d50f739d2e0b)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Improved apis Modular forms in progress - cabboose@[b846e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b846e015fd7b8b1f366c75acd3271a5cb37f8369)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Fix TanStack.Table module conflicts for dotnet build process - cabboose@[b11b9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b11b91addee7837ae260dbb9b4884f476c90f511)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* Bump dependencies Add support for Polymorphism to Kobalte - cabboose@[6af9e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/6af9e173fad5b6ffc09341ba0a01689b7dc33220)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Lucide

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* Bump dependencies Add support for Polymorphism to Kobalte - cabboose@[6af9e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/6af9e173fad5b6ffc09341ba0a01689b7dc33220)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# ModularForms

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* Typing adjustments in modular forms - cabboose@[94459](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/94459f7d63f7c180e389e8367f2d593702806b63)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Improved apis Modular forms in progress - cabboose@[b846e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b846e015fd7b8b1f366c75acd3271a5cb37f8369)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Motion

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* MotionStyle produces camelCased css properties instead of kebab-cased - cabboose@[be4bd](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/be4bdc3a04d78c86545309824f81b7b29bc9cdbd)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Finalisation of Partas.Solid.Motion api - cabboose@[a6d5b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/a6d5bc1759a589362728c14d8be37a25ac08dd26)
  

* Improve Motion bindings. Almost finalised. - cabboose@[2441e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/2441ed314a1a1de4988f3b04c89eaa5e075ce38d)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Improved apis Modular forms in progress - cabboose@[b846e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b846e015fd7b8b1f366c75acd3271a5cb37f8369)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* Adjustments for dx of Motion bindings - cabboose@[3d1e9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3d1e99607e556b07ed3a409c830993419e591aac)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Stub for Motion bindings - cabboose@[791c3](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/791c3a2e80338d44f67676d68d31acc15ad19236)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# NeoDrag

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Sonner

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =APEXCHARTS= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =ARKUI= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CMDK= 0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =CORVU=0.2.2 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =KOBALTE=0.3.5 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =MODULARFRAMES=0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility =SONNER= 0.2.1 REFACTOR: Use val mutable properties for Partas.Solid.Storybook compatibility - cabboose@[d2cea](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d2cea376a1ba1b484f0ebf95e2c7d56fd85c9326)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Storybook

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# Table

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Upgrade Partas.Solid to alpha98, enhance Motion bindings, and add NeoDrag module - cabboose@[44b9b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/44b9bb1e46d15ebddeea90d57da2a26c66d559b2)
  

* Update package references and add Partas.Solid.Motion module - cabboose@[fa454](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/fa454b8c40367ca61baabeecd8b4e3928bb22ee4)
  

* Add glutinum transformer for posterity - cabboose@[ffa45](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/ffa45135ad6ffe8530cc6d0e4a8f6526028f582e)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upd kobalte towards 1.0.0 spec - cabboose@[c19f8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/c19f89d93cd39dff120d0d97207f8ba4185ad2fb)
  

* update and refactor - cabboose@[b386b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b386bf957d5652d9d16c58767f5cab4ad1b49480)
  

* upd kobalte towards 1.0.0 spec - cabboose@[cc9a4](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/cc9a4589f7a0087e5ba519116c3098430ef07f32)
  

* Refactor extensions into pojo constructor for TableOptions and ColumnDef - cabboose@[cd3d9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/cd3d92cd65e39f20480efdd53e0dd57c3c881534)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Massive revamp of ModularForms, update dependencies - cabboose@[f7328](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/f732898a4c5d9ff4c007e5b2b50f7b8405215541)
  

* Improved apis Modular forms in progress - cabboose@[b846e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b846e015fd7b8b1f366c75acd3271a5cb37f8369)
  

* Update bindings to Pojos - cabboose@[93bc9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/93bc9e6b17c99a94f7ec753b73cd11187cd60431)
  

* Regenerate Lucide bindings to fix slow dev server load times on vite - cabboose@[3b34b](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b34b604eba5491c07a2eb30fd6406b2d99e356b)
  

* alpha impl embla - cabboose@[82418](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/82418bf08be6fa0bc9cdf05c893382bc64c218c1)
  

* OnChangeFn type signature corrected - cabboose@[40acc](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/40acc6bfacdbcce33765664cffd539f99a072845)
  

* Fix TanStack.Table module conflicts for dotnet build process - cabboose@[b11b9](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b11b91addee7837ae260dbb9b4884f476c90f511)
  

* Preliminary TanStack Table implementation - cabboose@[d93bf](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d93bf759f7627c78bd8061a93e37197f52600256)
  

* Complete implementation of TanStack.Table api - cabboose@[75f20](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/75f20ec2cd35f6c0fdb0f5aec0aa1c47bf2db48b)
  

* Update dependencies and remove JSType.Any (was not aware this was not from fable) - cabboose@[09604](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/096045ea651fba1b49e8186670ef80686a8cb263)
  

* SolidPrimitives: Added: - Scroll - @solid-primitives/scroll - Idle - @solid-primitives/idle - Timer - @solid-primitives/timer - Scheduled - @solid-primitives/scheduled - cabboose@[05b23](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/05b23c89b810358009d9aecc9bed2c983378334a)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

# ZagJs

## UNRELEASED

* add ci workflow - cabboose@[bb105](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/bb105fbdf0fb7446f663d388a10e8ada5a0f5e89)
  

* =KOBALTE= VERSION: 0.3.1 HOTFIX: Provide components without type params as alias - cabboose@[d8a3c](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/d8a3c8183219e9bc3e64638e9f4140f9fa429246)
  

* v1.0.0 Partas.Solid release - cabboose@[3b47d](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/3b47d542682bf70d4901fa2a3ee5cde1efcf1643)
  

* Bump versions, add Sonner, update some of the older bindings with better APIs. - cabboose@[e9cc5](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/e9cc5346070b7fad4d384b301851c08f3ca0b6a1)
  

* Dump - cabboose@[0a850](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/0a8503a51b628e7fc3a6828177b02b05ae195e5d)
  

* upgrade dependencies and remove cruft - cabboose@[87ec1](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/87ec101acd4b14565c7a7545e9cde183171e2446)
  

* Improved apis Modular forms in progress - cabboose@[b846e](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/b846e015fd7b8b1f366c75acd3271a5cb37f8369)
  

* Part bindings for several different libraries to enable calendar from solid-ui - cabboose@[67cb8](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/67cb817854a71139c13ae3f53b971b7bf338b7d7)
  

* upd - cabboose@[58361](https://github.com/shayanhabibi/Partas.Solid.Bindings/commit/583612088c29a484e80e0a90ee07e9248c242796)
  

-----------------------

<!-- generated by Partas.GitNet -->