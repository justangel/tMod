﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tMod_v3
{
    public enum PacketTypes : byte
    {
        Version = 1,
        Disconnect = 2,
        Connected = 3,
        Avatar = 4,
        InventorySlot = 5,
        Ready = 6,
        WorldParams = 7,
        RequestChunk = 8,
        Status = 9,
        SendRow = 0xa,
        CalculateFrame = 0xb,
        SpawnPlayer = 0xc,
        UpdatePlayer = 0xd,
        IsPlayerActive = 0xe,
        RequestPlayerSync = 0xf,
        PlayerLife = 0x10,
        ChangeTile = 0x11,
        UpdateTime = 0x12,
        UpdateDoor = 0x13,
        UpdateTiles = 0x14,
        DropItem = 0x15,
        ItemOwner = 0x16,
        NpcData = 0x17,
        PlayerHitNpc = 0x18,
        ChatMessage = 0x19,
        PlayerStrike = 0x1a,
        Projectile = 0x1b,
        StrikeNpc = 0x1c,
        DisposeProjectile = 0x1d,
        SetPvp = 0x1e,
        RequestChest = 0x1f,
        ChestItem = 0x20,
        OpenChest = 0x21,
        KillTile = 0x22,
        HealEffect = 0x23,
        SetZone = 0x24,
        RequestPassword = 0x25,
        SendPassword = 0x26,
        RemoveItemOwner = 0x27,
        TalkToNpc = 0x28,
        PlayerAnimation = 0x29,
        PlayerMana = 0x2a,
        ManaEffect = 0x2b,
        PlayerDeath = 0x2c,
        ChangeTeams = 0x2d,
        RequestSign = 0x2e,
        Sign = 0x2f,
        SetLiquid = 0x30,
        SpawnSelf = 0x31,
    }
}
