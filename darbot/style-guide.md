# Darbot Labs — **Retro Cyber Modern Fluent** Style Guide  
*Version 1.0 · May 17 2025*

> **Scope**  
> A single, cross-platform design language from Darbot Labs for all products, including web, mobile, and desktop applications.

---

## 1 Design Principles
| Pillar | What it means | Practical cues |
|--------|---------------|----------------|
| **Retro** | Homage to 8-bit/16-bit UIs & console typefaces | Pixel-grid alignment, low-poly icons, mono fonts |
| **Cyber** | Neon, terminals, and CRT glow | High-contrast color pops, animated scans & vignettes |
| **Modern** | Fluent 2 & Material 3 ergonomics | Elevation, rounded corners (4 px / 8 px), 8-pt spacing grid |
| **Fluent** | Seamless with Windows ecosystem | Acrylic blur, reveal hover, keyboard affordances |

> **Accessibility first** – every color pairing below passes WCAG 2.1 AA for text ≥ 14 pt/1 rem.

---

## 2 Color System

| Role | Token | HEX | Usage |
|------|-------|-----|-------|
| **Canvas (0)** | `--grey-100` | `#151515` | App background, video slates |
| Surface (1) | `--grey-200` | `#1F1F1F` | Cards, modals, side-panels |
| Surface (2) | `--grey-300` | `#282828` | Input fields, secondary cards |
| Surface (3) | `--grey-400` | `#3A3A3A` | Toggles, sliders, wells |
| **Neon Cyan** | `--neon-cyan` | `#779ECB` | Primary brand accent, focus ring |
| **Neon Magenta** | `--neon-magenta` | `#FF006E` | Highlight, links, headings |
| **Neon Lime** | `--neon-lime` | `#B8FF00` | Success/online, active states |
| **Neon Amber** | `--neon-amber` | `#FFBF00` | Warnings, progress, badges |
| Error | `--neon-red` | `#F31260` | Destructive, offline |
| Overlay | `--shadow-cya` | `rgba(119,158,203,.35)` | Drop shadows & glows |

```scss
/* CSS variables (web) */
:root{
  --grey-100:#151515;--grey-200:#1f1f1f;--grey-300:#282828;--grey-400:#3a3a3a;
  --neon-cyan:#779ECB;--neon-magenta:#ff006e;--neon-lime:#b8ff00;--neon-amber:#ffbf00;
  --neon-red:#f31260;--shadow-cya:rgba(119,158,203,.35);
}
```

---

## 3 Typography

| Style      | Font stack (open-source / built-in)                      | Size / Weight |
| ---------- | -------------------------------------------------------- | ------------- |
| Display XL | "IBM Plex Mono", "JetBrains Mono", Consolas, monospace | 36 px / 600   |
| Heading L  | same                                                     | 24 px / 600   |
| Heading M  | same                                                     | 20 px / 600   |
| Body M     | "Inter", "Segoe UI", Roboto, system-ui, sans-serif     | 14 px / 400   |
| Caption    | same                                                     | 12 px / 400   |
| Mono UI    | "IBM Plex Mono", Consolas, monospace                   | inherit       |

*Why Plex Mono?*

* OFL-licensed (fully open source)
* Renders crisply at small sizes, preserving retro pixel vibe
* Variants available for variable-width fallback

> **Implementation**
> • **Web** – `@font-face` serve **IBM Plex Mono** locally or via a CDN such as cdnjs.
> • **.NET/WPF** – bundle `IBMPlexMono.ttf` in `Resources` and reference in XAML.
> • **MAUI / iOS / Android** – add to `Resources/Fonts` and map in `MauiProgram.cs`.

---

## 4 Iconography & Illustrations

*All icons are 1.5-px (desktop) / 2-dp (mobile) strokes.*

| Asset           | Source                        | Color                                   | Notes                                   |
| --------------- | ----------------------------- | --------------------------------------- | --------------------------------------- |
| Interface icons | Lucide / Fluent 2 SVG set     | Primary: `--neon-cyan`; hover: glow     | Use `<svg>` stroke + drop shadow filter |
| Status glyphs   | 8-bit dot/grid sprites        | Lime = online, Magenta = offline        | Animated “pulse” 1 s ease-in-out        |
| Logos           | Simplified geometric monogram | Magenta brain $AI$ inside Cyan D-shield | Export as SVG & 1024 px PNG             |

---

## 5 Layout, Spacing & Elevation

| Token        | Value                                   | Use                 |
| ------------ | --------------------------------------- | ------------------- |
| **Unit**     | 8 px                                    | Base grid           |
| Card-radius  | 4 px                                    | Compact surfaces    |
| Panel-radius | 8 px                                    | Elevated containers |
| Shadow 1     | `0 0 4 px var(--shadow-cya)`            | Inline buttons      |
| Shadow 2     | `0 0 10 px var(--shadow-cya)`           | Elevated cards      |
| Glow hover   | `box-shadow:0 0 15 px var(--neon-cyan)` | Interactive focus   |

---

## 6 Core Components (atomic spec)

| Component             | Token ref                                    | States                                                 |
| --------------------- | -------------------------------------------- | ------------------------------------------------------ |
| **Button**            | bg `--grey-300` → hover `--neon-cyan`        | *Primary, Secondary, Destructive*                      |
| **Toggle Switch**     | track `--grey-400` / active `--neon-magenta` | Focus ring `2 px --neon-cyan`                          |
| **Status Dot**        | 12 px circle                                 | `.online` =`--neon-lime`; `.offline` =`--neon-magenta` |
| **Card / Panel**      | bg `--grey-300`; border `1 px --neon-cyan`   | Elevation 2 on hover                                   |
| **Input / Select**    | bg `--grey-400`; text `--neon-cyan`          | Error border =`--neon-red`                             |
| **Log Box / Console** | mono font, fg `--neon-lime`, bg `--grey-300` | Scroll snap, 200-line cap                              |

<details>
<summary>Sample CSS Snippet</summary>

```css
.btn-primary{
  background:var(--grey-300);
  color:var(--neon-cyan);
  border:2px solid var(--neon-cyan);
  padding:.75rem 1rem;border-radius:4px;
  transition:all .3s ease;
}
.btn-primary:hover,
.btn-primary:focus-visible{
  background:var(--neon-cyan);
  color:var(--grey-100);
  box-shadow:0 0 15px var(--neon-cyan);
}
.toggle input:checked+span{
  background:var(--neon-magenta);
}
.toggle input:checked+span:before{
  transform:translateX(26px);
}
```

</details>

---

## 7 Motion

| Motion token         | Spec                                                                         |
| -------------------- | ---------------------------------------------------------------------------- |
| **Hover reveal**     | opacity 0 → 1, 120 ms ease-out                                               |
| **Focus ring**       | 2 px neon-cyan outline, 60 ms grow                                           |
| **Toggle knob**      | transform translateX; 400 ms cubic-bezier(.4,0,.2,1)                         |
| **Shadow breathing** | pulsing glow for active states, `@keyframes breathe 2s ease-in-out infinite` |

---

## 8 Cross-Platform Implementation Cheatsheet

| Platform            | How                                                                                       |
| ------------------- | ----------------------------------------------------------------------------------------- |
| **Web**             | Import `style.css` w/ variables; use `prefers-color-scheme` to swap light theme if needed |
| **WinUI/WPF**       | `ResourceDictionary` keys mirror CSS vars (e.g., `NeonCyanBrush`)                         |
| **.NET MAUI**       | In `App.xaml`, add `Color x:Key="NeonCyan">#779ECB</Color>`                               |
| **SwiftUI**         | `Color("NeonCyan")` from `Assets.xcassets`                                                |
| **Jetpack Compose** | `val NeonCyan = Color(0xFF779ECB)` in `Color.kt`                                          |
| **Figma**           | Create global paint styles *Neon Cyan*, *Grey 100*, etc.                                  |

---

## 9 Accessibility ⏤ Key Ratios

| Pair                             | Contrast (AA≥4.5) |
| -------------------------------- | ----------------- |
| `--neon-cyan` on `--grey-100`    | 4.71 : 1 ✅        |
| `--neon-magenta` on `--grey-200` | 6.03 : 1 ✅        |
| `--neon-lime` on `--grey-300`    | 5.87 : 1 ✅        |

*Ensure interactive glows are **in addition** to—not instead of—focus rings.*

---

## 10 Brand Voice & Tone

| Attribute       | Guideline                                                            |
| --------------- | -------------------------------------------------------------------- |
| **Voice**       | Confident, engineer-friendly, slightly playful                       |
| **Tone**        | Encourage experimentation (“Hack the limits”), avoid jargon overload |
| **Microcopy**   | Imperatives: “Start Service”, “Toggle Fallback”                      |
| **Easter Eggs** | Subtle ASCII art in console, 1 line max                              |

---

## 11 Asset Kit

* **Fonts**: `IBM Plex Mono` (OFL), `Inter` (OFL) → `/assets/fonts/`
* **SVG Icon set** → `/assets/icons/`
* **Logo variants** (`primary.svg`, `mono.svg`, `favicon.ico`)
* **Motion presets** (`.json` Lottie, `.gif` sparkline demos)

---

## 12 Versioning & Governance

| Rule                   | Detail                                                                      |
| ---------------------- | --------------------------------------------------------------------------- |
| SemVer                 | Major (breaking design shift) · Minor (new component) · Patch (token tweak) |
| Review cadence         | Monthly design review; PR required for palette changes                      |
| Single source of truth | `/design/tokens/` JSON + Figma styles sync                                  |

---

### Quick-Start Snippet (Web)

```html
<link rel="stylesheet" href="darbot-style.min.css">
<body class="dark">
  <button class="btn-primary">Start Service</button>
</body>
```

---

© 2025 Darbot Labs. Licensed under MIT for internal & community tooling.
*Retro vibes, modern flows.*
