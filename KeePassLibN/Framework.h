/*
  KeePassLibN
  Copyright (C) 2003-2025 Dominik Reichl <dominik.reichl@t-online.de>

  This program is free software; you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation; either version 2 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program; if not, write to the Free Software
  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#ifndef ___FRAMEWORK_H___
#define ___FRAMEWORK_H___

#pragma once

#define WIN32_LEAN_AND_MEAN

#include <cassert>
#include <climits>
#include <cstdint>
#include <cstdlib>
#include <cstring>
#include <memory>
#include <vector>

#include <Windows.h>

#ifdef KPL_IMPORT
#define KPL_API extern "C" __declspec(dllimport)
#else
#define KPL_API extern "C" __declspec(dllexport)
#endif

#endif // ___FRAMEWORK_H___
