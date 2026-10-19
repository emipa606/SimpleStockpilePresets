# GitHub Copilot Instructions for Simple Stockpile Presets (Continued)

## Mod Overview and Purpose
Simple Stockpile Presets (Continued) is a quality-of-life mod for RimWorld, updated from Lanilor's original mod. The primary purpose of this mod is to enhance the usability of stockpile management by introducing easy-to-apply storage presets. These presets allow players to set commonly used storage configurations in a convenient floating menu, aiming to simplify and speed up the process of organizing stockpiles with both generic and specific configurations.

Key objectives are:

- To avoid unnecessary micromanagement by providing commonly used storage setups.
- To not add or change the core content of the game but improve user interaction with existing systems.

## Key Features and Systems
- **Storage Presets**: Provides presets for various common and thematic stockpile settings, such as freezer items, food, drugs, weapons, or clean apparel.
- **User Interface Enhancements**: Uses floating menus to integrate presets seamlessly into the stockpile UI.
- **Localization**: Includes a French translation, enhancing accessibility for French-speaking players.

## Coding Patterns and Conventions
- **Source Organization**: The mod's source files are organized with each core feature or extension in separate C# files, making it easy to navigate and understand the structure.
- **Naming Conventions**: Uses PascalCase for class names and methods, following typical C# conventions. Classes like `AdditionalThingCategoryDefOf` or `Command_StorageSettingsPresets` are named according to their responsibilities.
- **Comments and Documentation**: Where applicable, add comments to describe the purpose of intricate or complex methods, especially those involving harmony patches or significant game behavior changes.

## XML Integration
Currently, this mod does not utilize XML files or defs directly. However, potential XML integration could involve:

- Defining presets in XML for easier modification or extension without altering C# code.
- Utilizing XML patches for better compatibility with other mods or future game versions.

## Harmony Patching
Harmony is used to non-destructively inject and modify the behavior of RimWorld's classes without editing the game files:

- **Patching Strategy**: Patches are applied primarily in methods that handle UI methods related to stockpile management, ensuring minimal disruption.
- **Example**: The `Harmony_Zone_Stockpile_GetGizmos.cs` file contains a postfix method that extends the base game functionality without changing its core behavior.
- **Best Practices**: Ensure harmony patches are well-documented and only applied where necessary to improve maintainability and compatibility.

## Suggestions for Copilot
To make effective use of GitHub Copilot for this project:

- **Pattern Recognition**: Leverage Copilot to generate repetitive code patterns, like similar methods or classes across the mod's different systems.
- **Assistance with Harmony**: Use Copilot to assist in generating complex Harmony patches by providing structured examples and suggestions.
- **UI Additions**: Utilize Copilot to create UI elements, such as floating menus, by analyzing similar modifications in other parts of the codebase.
- **Localization Help**: Automatically generate translation tokens or keys accompanied by simple stubs for ease of localization efforts.

By adhering to these guidelines, you can maintain and extend the Simple Stockpile Presets (Continued) mod effectively while leveraging modern code assistance tools.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

