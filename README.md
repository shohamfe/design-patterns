# Facebook Desktop App — WinForms (C#) - ON PROCESS

A Windows Forms application that integrates with the Facebook Graph API to provide a desktop interface for browsing user feeds, managing friends, viewing albums, and analyzing profile data.
This project demonstrates the practical application of **Object-Oriented Design Patterns** (Singleton, Factory, Strategy) to create a maintainable and scalable architecture.

---

## Features
- **User Authentication:** Secure login via Facebook Graph API (singleton session management).
- **Dashboard & Bio:** View profile picture, cover photo, and editable bio details.
- **Dynamic Content Grids:** Universal grid components to display:
  - Photo Albums
  - Friend Lists
  - Liked Pages
  - Saved Posts
- **Theming System:** Real-time switching between multiple UI themes (Light, Dark, Facebook Blue).
- **Custom Feeds:** Specialized views for the standard News Feed and a "Close Friends" filter.
- **Offline/Mock Mode:** Includes robust mock data handling (JSON) to simulate API responses for development and testing.

---

## Project structure
FacebookWinFormsApp/
├─ Program.cs // Application entry point
├─ UI/
│  ├─ Forms/
│  │  └─ MainForm.cs // Main navigation container and tab controller
│  ├─ Components/ // Reusable User Controls
│  │  ├─ LoginComponent.cs // Handle login/logout UI
│  │  ├─ BioComponent.cs // User profile header and stats
│  │  ├─ TitledGridComponent.cs // Generic container for lists (Albums/Friends/etc.)
│  │  ├─ GridItemComponent.cs // UI for a single item (image + text) within a grid
│  │  ├─ FeedPageComponent.cs // Logic for displaying post feeds
│  │  └─ CloseFriendsFeedComponent.cs // Specialized feed logic
├─ Logic/
│  ├─ Managers/ // Business logic providers
│  │  ├─ AlbumsGridManager.cs, FriendsGridManager.cs, etc. // Strategies for fetching specific data
│  │  └─ BioManager.cs // Handles user profile data retrieval
│  ├─ Models/
│  │  ├─ AppTheme.cs // Defines color palettes for theming
│  │  └─ PostDetails.cs, BioDetails.cs // Data transfer objects
│  └─ Helpers/
│     └─ ThemeColorizer.cs // Utilities for applying colors to controls
├─ Factories/
│  ├─ GridManagerFactory.cs // Creates specific data managers based on context
│  └─ ThemeFactory.cs // Generates theme instances (Light/Dark/Custom)
├─ Singletons/
│  ├─ FacebookSession.cs // Manages auth state and API wrapper instance
│  └─ ThemeManager.cs // Centralized state for the current active theme
└─ Resources/ // Icons, Placeholders, and Mock Data (JSON)

---

## Usage
1. **Login:** Launch the app and click "Login" to authenticate via the Facebook popup.
2. **Navigation:** Use the tabs to switch between:
   - **Profile:** View bio, albums, and pages.
   - **Feed:** Read recent posts from your network.
   - **Close Friends:** Filtered view of specific interactions.
3. **Theming:** Use the theme toggle/selector to switch between "Light," "Dark," or "Facebook" visual styles.
4. **Data Interaction:** Click on grid items (like Albums) to view details (if implemented) or interact with the list.

---

## Implementation notes (Design Patterns)

### `Singleton Pattern`
- **`FacebookSession.cs`:** Ensures only one user session exists throughout the application lifecycle. It handles the connection to the `FbGraphApiWrapper`.
- **`ThemeManager.cs`:** Maintains the global state of the selected application theme and notifies subscribers when the theme changes.

### `Factory Method Pattern`
- **`GridManagerFactory.cs`:** Encapsulates the object creation logic for data managers. It returns the correct implementation of `IGridItemManager` (e.g., `AlbumsGridManager`, `FriendsGridManager`) based on the requested `eGridItemType`.
- **`ThemeFactory.cs`:** Responsible for instantiating `AppTheme` objects based on the user's selection (`eThemeType`).

### `Strategy Pattern`
- **`IGridItemManager.cs`:** Defines a common interface for fetching and processing data. The `TitledGridComponent` relies on this abstraction, allowing it to display Albums, Friends, or Pages interchangeably without knowing the underlying data source. The specific "Strategy" (Manager) is injected at runtime.

### `UI Components`
- **`TitledGridComponent`:** A high-level container that composes a title and a dynamic flow layout panel. It uses the injected Manager to populate itself.
- **`BioComponent`:** Isolates the complexity of displaying user statistics (likes, friends count) and profile images.

---

## screenshots
<img width="1243" height="811" alt="Screenshot 2025-12-15 105911" src="https://github.com/user-attachments/assets/dd9a821d-8716-4df0-b291-859346611d48" />
<img width="984" height="645" alt="Screenshot 2025-12-15 105947" src="https://github.com/user-attachments/assets/6d22535a-e53f-4b99-9db0-0928fda66a98" />
<img width="991" height="652" alt="Screenshot 2025-12-15 110048" src="https://github.com/user-attachments/assets/46781c60-6270-437e-afdb-054e69af31f6" />
<img width="988" height="648" alt="Screenshot 2025-12-15 110107" src="https://github.com/user-attachments/assets/70db7eb9-d747-4153-bff1-424ce6259107" />

---

## Future improvements
- **Write Post:** Ability to post status updates directly from the desktop client.
- **Advanced Filtering:** Sort friends by interaction frequency or location.
- **Pagination:** Load feed items and albums in chunks to improve performance.
- **Caching:** Local SQLite cache to view downloaded data while offline.
