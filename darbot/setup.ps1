# Install Visual Studio Build Tools and Windows App SDK
Write-Host 'Installing dependencies...'

# Install winget if not present
if (-not (Get-Command winget -ErrorAction SilentlyContinue)) {
    Write-Host 'Winget not found. Please install from the Microsoft Store.'
    exit 1
}

winget install --id Microsoft.VisualStudio.2022.Community -e --source winget
winget install --id Microsoft.WindowsAppSDK -e --source winget

# Enable Developer Mode
reg add "HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\AppModelUnlock" /t REG_DWORD /f /v "AllowDevelopmentWithoutDevLicense" /d "1"

# Clone repo
if (-not (Test-Path Darbot9Bit)) {
    git clone https://github.com/darbotlabs/darbot-winappsamp.git Darbot9Bit
}

Write-Host 'Setup complete. Open Darbot9Bit\darbot\Darbot9BitEngine.sln in Visual Studio.'
