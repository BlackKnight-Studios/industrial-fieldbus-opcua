# industrial-fieldbus-opcua

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![.NET](https://img.shields.io/badge/.NET-6.0%20%7C%20Standard%202.0-purple.svg)](#)
[![Throughput](https://img.shields.io/badge/polling__rate-1000%20Hz-emerald.svg)](#)

High-performance OPC UA and Siemens S7 PLC communication bridge for hardware-in-the-loop (HIL) virtual commissioning and real-time digital twins.

```mermaid
graph LR
    A[Siemens S7 / TwinCAT PLC] -->|ISO-on-TCP / ADS| B[Fieldbus Driver]
    B -->|Lock-Free Ring Buffer| C[Tag Cache 1000 Hz]
    C -->|Shared Memory / WebSockets| D[3D Digital Twin Runtime]
```

## Features

- **Microsecond Timestamping**: Lock-free concurrent tag cache delivering updates at 1 kHz with minimal jitter.
- **Multi-Vendor PLC Support**: Native drivers for Siemens S7 (S7-300, S7-1200, S7-1500), Beckhoff TwinCAT ADS, and OPC Foundation client.
- **Fail-Safe Watchdog**: Automated heartbeat and reconnection logic for non-disruptive physical line commissioning.

## License

MIT License (c) 2018-2026 Gaurav Bhardwaj / OmegaGaze Lab.
